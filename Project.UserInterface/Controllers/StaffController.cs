using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.UserInterface.Models.Staff;

namespace Project.UserInterface.Controllers
{
	public class StaffController : Controller
	{
		readonly IHttpClientFactory _httpClientFactory;

		public StaffController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5293/api/Staff");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);
				return View(values);
			}

			return View();
		}
	}
}
