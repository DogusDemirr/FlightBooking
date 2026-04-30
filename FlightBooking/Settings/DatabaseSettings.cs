namespace FlightBooking.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        /// <summary>
        /// ConnectionString
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// DatabaseName
        /// </summary>
        public string DatabaseName { get; set; }
        /// <summary>
        /// FlightCollectionName
        /// </summary>
        public string FlightCollectionName { get; set; }
    }
}
