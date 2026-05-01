namespace FlightBooking.Dtos.FlightDtos
{
    public class CreateFlightDto
    {
        /// <summary>
        /// FlightNumber
        /// </summary>
        public string FlightNumber { get; set; }
        /// <summary>
        /// AirlineCode
        /// </summary>
        public string AirlineCode { get; set; }
        /// <summary>
        /// DepartureAirportCode
        /// </summary>
        public string DepartureAirportCode { get; set; }
        /// <summary>
        /// DepartureAirPortName
        /// </summary>
        public string DepartureAirportName { get; set; }
        /// <summary>
        /// ArrivalAirportCode
        /// </summary>
        public string ArrivalAirportCode { get; set; }
        /// <summary>
        /// ArrivalAirportName
        /// </summary>
        public string ArrivalAirportName { get; set; }
        /// <summary>
        /// DepartureTime
        /// </summary>
        public DateTime DepartureTime { get; set; }
        /// <summary>
        /// ArrivalTime
        /// </summary>
        public DateTime ArrivalTime { get; set; }
        /// <summary>
        /// DurationMinutes
        /// </summary>
        public int DurationMinutes { get; set; }
        /// <summary>
        /// TotalSeats
        /// </summary>
        public int TotalSeats { get; set; }
        /// <summary>
        /// AvailableSeats
        /// </summary>
        public int AvailableSeats { get; set; }
        /// <summary>
        /// BasePrice
        /// </summary>
        public decimal BasePrice { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }
    }
}
