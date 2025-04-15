using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.Areas.User.ViewComponents.UserLayoutComponents
{
    public class _UserLayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
