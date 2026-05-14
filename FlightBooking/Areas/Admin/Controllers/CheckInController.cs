using AutoMapper;
using FlightBooking.Constants;
using FlightBooking.Entities;
using FlightBooking.Settings;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace FlightBooking.Areas.Admin.Controllers
{
    [Area(ProjectContants.ADMIN)]
    public class CheckInController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Flight> _flightCollection;
        private readonly IMongoCollection<Booking> _bookingCollection;

        public CheckInController(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _flightCollection = database.GetCollection<Flight>(databaseSettings.FlightCollectionName);
            _bookingCollection = database.GetCollection<Booking>(databaseSettings.BookingCollectionName);
            _mapper = mapper;
        }
        public IActionResult Index(string id)
        {
            var viewBag = ViewBag;
            viewBag.FlightNumber = TempData["FlightNumber"];
            viewBag.DepartureTime = TempData["DepartureTime"];
            viewBag.ArrivalTime = TempData["ArrivalTime"];

            return View();
        }
    }
}
