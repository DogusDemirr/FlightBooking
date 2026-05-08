namespace FlightBooking.Entities
{
    public class CheckIn
    {
        /// <summary>
        /// CheckInId
        /// </summary>
        public string CheckInId { get; set; }
        /// <summary>
        /// PassengerId
        /// </summary>
        public string PassengerId { get; set; }
        /// <summary>
        /// FlightId
        /// </summary>
        public string FlightId { get; set; }
        /// <summary>
        /// PnrNumber
        /// </summary>
        public string PnrNumber { get; set; }
        /// <summary>
        /// CheckInDate
        /// </summary>
        public DateTime CheckInDate { get; set; }
        /// <summary>
        /// IsCheckedIn
        /// </summary>
        public bool IsCheckedIn { get; set; }
        /// <summary>
        /// SeatNumber
        /// </summary>
        public string SeatNumber { get; set; }
        /// <summary>
        /// ExtraTotalPrice
        /// </summary>
        public decimal ExtraTotalPrice { get; set; }
    }
}
