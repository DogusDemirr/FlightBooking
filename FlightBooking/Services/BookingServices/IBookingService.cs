using FlightBooking.Dtos.BookingDtos;

namespace FlightBooking.Services.BookingServices
{
    public interface IBookingService
    {
        Task CreateBookingAsync(CreateBookingDto createBookingDto);
        Task<(string Name, string SurName)> GetPassengerNameByIdAsync(string passengerId);
    }
}
