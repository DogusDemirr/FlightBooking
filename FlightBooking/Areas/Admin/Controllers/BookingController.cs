using FlightBooking.Dtos.BookingDtos;
using FlightBooking.Services.FlightServices;
using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookingController : Controller
    {
        private readonly IFlightService _flightService;
        //private readonly IBookingService _bookingService;
        public BookingController(IFlightService flightService)
        {
            _flightService = flightService;
            //_bookingService = bookingService;
        }

        [HttpGet]
        public async Task<IActionResult> CreateBooking(string id)
        {
            var viewBag = ViewBag;
            var value = await _flightService.GetFlightByIdAsync(id);
            viewBag.id = id;
            viewBag.FlightNumber = value.FlightNumber;
            viewBag.DepartureAirportCode = value.DepartureAirportCode;
            viewBag.DepartureAirportName = value.DepartureAirportName;
            viewBag.ArrivalAirportCode = value.ArrivalAirportCode;
            viewBag.ArrivalAirportName = value.ArrivalAirportName;
            viewBag.DepartureTime = value.DepartureTime;
            viewBag.ArrivalTime = value.ArrivalTime;
            viewBag.AirlineCode = value.AirlineCode;
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateBooking(CreateBookingDto createBookingDto)
        //{
        //    await _bookingService.CreateBookingAsync(createBookingDto);
        //    return RedirectToAction("Index", "Bookings", new { area = "Admin" });
        //}

        public IActionResult BookingList()
        {
            return View(); 
        }
    }
}
