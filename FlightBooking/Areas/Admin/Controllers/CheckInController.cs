using FlightBooking.Constants;
using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Controllers
{
    [Area(ProjectContants.ADMIN)]
    public class CheckInController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewBag.FlightNumber = TempData["FlightNumber"];
            return View();
        }
    }
}
