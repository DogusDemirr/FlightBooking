using FlightBooking.Dtos.FlightDtos;

namespace FlightBooking.Services.FlightServices
{
    public interface IFlightService
    {
        /// <summary>
        /// GetAllFlightsAsync
        /// </summary>
        /// <returns></returns>
        Task<List<ResultFlightDto>> GetAllFlightsAsync();
        /// <summary>
        /// GetFlightByIdAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<GetFlightByIdDto> GetFlightByIdAsync(string id);
        /// <summary>
        /// CreateFlightAsync
        /// </summary>
        /// <param name="createFlightDto"></param>
        /// <returns></returns>
        Task CreateFlightAsync(CreateFlightDto createFlightDto);
        /// <summary>
        /// DeleteFlightAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteFlightAsync(string id);
        /// <summary>
        /// UpdateFlightDto
        /// </summary>
        /// <param name="updateFlightDto"></param>
        /// <returns></returns>
        Task UpdateFlightAsync(UpdateFlightDto updateFlightDto);
    }
}
