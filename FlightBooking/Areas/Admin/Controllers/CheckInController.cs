using AutoMapper;
using FlightBooking.Constants;
using FlightBooking.Entities;
using FlightBooking.Services.BookingServices;
using FlightBooking.Settings;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace FlightBooking.Areas.Admin.Controllers
{
    [Area(ProjectContants.ADMIN)]
    public class CheckInController : Controller
    {
        //private readonly IMapper _mapper;
        //private readonly IMongoCollection<Flight> _flightCollection;
        //private readonly IMongoCollection<Booking> _bookingCollection;
        private readonly IBookingService _bookingService;

        public CheckInController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        //public CheckInController(IMapper mapper, IDatabaseSettings databaseSettings)
        //{
        //    var client = new MongoClient(databaseSettings.ConnectionString);
        //    var database = client.GetDatabase(databaseSettings.DatabaseName);
        //    _flightCollection = database.GetCollection<Flight>(databaseSettings.FlightCollectionName);
        //    _bookingCollection = database.GetCollection<Booking>(databaseSettings.BookingCollectionName);
        //    _mapper = mapper;
        //}
        public async Task<IActionResult> Index(string id)
        {
            var viewBag = ViewBag;
            viewBag.FlightNumber = TempData["FlightNumber"];
            viewBag.DepartureTime = TempData["DepartureTime"];
            viewBag.ArrivalTime = TempData["ArrivalTime"];

            var passenger = await _bookingService.GetPassengerNameByIdAsync(id);

            viewBag.Name = passenger.Name;
            viewBag.Surname = passenger.SurName;

            return View();
        }
    }
}
