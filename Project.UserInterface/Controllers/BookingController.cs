using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.UserInterface.DTOs.BookingDto;
using System.Text;

namespace Project.UserInterface.Controllers
{
	public class BookingController : Controller
	{
		readonly IHttpClientFactory _httpClientFactory;

		public BookingController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> MakeReservation(BookingInsertDto bookingInsertDto)
		{
			if (!ModelState.IsValid)
			{
				return View("Index", bookingInsertDto);
			}

			bookingInsertDto.Status = "Mail onayı bekleniyor.";
			bookingInsertDto.Description = "Mail onayı bekleniyor1.";
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(bookingInsertDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("http://localhost:5293/api/Booking", stringContent);

			if (responseMessage.IsSuccessStatusCode)
			{
				TempData["SuccessfullBooking"] = "Rezervasyon isleminiz gerceklesti. Lutfen mailinize gelen maili onaylayiniz.";
				return RedirectToAction("Index");
			}

			return RedirectToAction("Index");
		}
	}
}
