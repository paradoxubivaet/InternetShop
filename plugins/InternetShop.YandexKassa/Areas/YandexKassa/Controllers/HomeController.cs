using Microsoft.AspNetCore.Mvc;

namespace InternetShop.YandexKassa.Areas.YandexKassa.Controllers
{
    [Area("YandexKassa")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // /YandexKassa/Home/Callback
        public IActionResult Callback()
        {
            return View();
        }

    }
}
