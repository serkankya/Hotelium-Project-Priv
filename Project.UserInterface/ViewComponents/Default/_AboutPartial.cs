using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.UserInterface.DTOs.AboutDto;

namespace Project.UserInterface.ViewComponents.Default
{
    public class _AboutPartial : ViewComponent
    {
        readonly IHttpClientFactory _httpClientFactory;

        public _AboutPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5293/api/About");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AboutResultDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
