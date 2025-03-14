using Microsoft.AspNetCore.Mvc;

namespace Project.UserInterface.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
