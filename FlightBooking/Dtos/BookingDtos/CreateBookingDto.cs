using FlightBooking.Dtos.PassengerDtos;

namespace FlightBooking.Dtos.BookingDtos
{
    public class CreateBookingDto
    {
        /// <summary>
        /// FlightId
        /// </summary>
        public string FlightId { get; set; }
        /// <summary>
        /// Passengers
        /// </summary>
        public List<CreatePassengerDto> Passengers { get; set; }
        /// <summary>
        /// ContactName
        /// </summary>
        public string ContactName { get; set; }
        /// <summary>
        /// ContactEmail
        /// </summary>
        public string ContactEmail { get; set; }
        /// <summary>
        /// ContactPhone
        /// </summary>
        public string ContactPhone { get; set; }
        /// <summary>
        /// PnrNumber
        /// </summary>
        public string PnrNumber { get; set; }
    }
}
