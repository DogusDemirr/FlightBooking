using FlightBooking.Constants;
using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Controllers
{
    [Area(ProjectContants.ADMIN)]
    public class CheckInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
