using Microsoft.AspNetCore.Mvc;

namespace Project.UserInterface.ViewComponents.Default
{
    public class _RoomPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
