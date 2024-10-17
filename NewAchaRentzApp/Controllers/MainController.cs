using Microsoft.AspNetCore.Mvc;

namespace WebPagesMvc.Controllers
{
    public class MainController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult RegistrationPage()
        {
            return View();
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult ExtraRegistrationDetailsPage()
        {
            return View();
        }
        public IActionResult CarsListingPage()
        {
            return View();
        }
        public IActionResult CarBookingPage()
        {
            return View();
        }
        public IActionResult testview()
        {
            return View();
        }
        public IActionResult RegisterACarPage()
        {
            return View();
        }
        public IActionResult UploadCarImagesPage()
        {
            return View();
        }
        public IActionResult ErrorPage()
        {
            return View();
        }
    }
}
