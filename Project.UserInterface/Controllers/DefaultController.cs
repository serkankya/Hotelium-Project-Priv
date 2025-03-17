using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.UserInterface.DTOs.SubscriberDto;
using System.Text;

namespace Project.UserInterface.Controllers
{
	public class DefaultController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public DefaultController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> InsertSubscription(SubscriberInsertDto subscriberInsertDto)
		{
			if(!ModelState.IsValid)
			{
				return View();
			}

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(subscriberInsertDto);
			StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
			var responseMessage = await client.PostAsync("http://localhost:5293/api/Subscriber", content);

			if (responseMessage.IsSuccessStatusCode)
			{
				TempData["SuccessfullSubscription"] = "Mail kayit isleminiz basariyla gerceklesti.";
				return RedirectToAction("Index");
			}

			return View();
		}
	}
}
