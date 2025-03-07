using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.UserInterface.Models.Staff;
using Project.UserInterface.Models.Testimonial;
using System.Text;

namespace Project.UserInterface.Controllers
{
	public class TestimonialController : Controller
	{
		readonly IHttpClientFactory _httpClientFactory;

        public TestimonialController(IHttpClientFactory httpClientFactory)
        {
				_httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5293/api/Testimonial");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<TestimonialViewModel>>(jsonData);
				return View(values);
			}

			return View();
		}

		[HttpGet]
		public IActionResult InsertTestimonial()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> InsertTestimonial(InsertTestimonialViewModel model)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("http://localhost:5293/api/Testimonial",content);

			if(responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			return View();
		}

		public async Task<IActionResult> DeleteTestimonial(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"http://localhost:5293/api/Testimonial/{id}");

			if(responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			return View();
		}

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5293/api/Testimonial/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateTestimonialViewModel>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5293/api/Testimonial/", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
