namespace FlightBooking.Entities
{
    public class Passenger
    {
        /// <summary>
        /// PassengerId
        /// </summary>
        public string PassengerId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Surname
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// BirthDate
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Gender
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// PassengerType
        /// </summary>
        public string PassengerType { get; set; }
        /// <summary>
        /// Gate
        /// </summary>
        public string? Gate { get; set; }
        /// <summary>
        /// SeatNumber
        /// </summary>
        public string? SeatNumber { get; set; }
        /// <summary>
        /// Check-In Status
        /// </summary>
        public string? CheckInStatus { get; set; }

        /// <summary>
        /// TicketStatus
        /// </summary>
        public string? TicketStatus { get; set; }
        /// <summary>
        /// PaymentStatus
        /// </summary>
        public string? PaymentStatus { get; set; }
    }
}
