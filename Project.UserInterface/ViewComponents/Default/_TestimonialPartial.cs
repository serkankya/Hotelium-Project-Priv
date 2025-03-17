using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.UserInterface.DTOs.TestimonialDto;

namespace Project.UserInterface.ViewComponents.Default
{
	public class _TestimonialPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _TestimonialPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5293/api/Testimonial");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<TestimonialResultDto>>(jsonData);
				return View(values);
			}

			return View();
		}
	}
}
