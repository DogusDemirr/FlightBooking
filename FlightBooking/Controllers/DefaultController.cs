using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Controllers
{
    public class DefaultController : Controller
    {
        /// <summary>
        /// Theme Home Page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
