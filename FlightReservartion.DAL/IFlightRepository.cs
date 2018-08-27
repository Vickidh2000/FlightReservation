using System.Collections.Generic;

namespace FlightReservartion.DAL
{
    public interface IFlightRepository
    {
        Flight GetFlightById(string id);

        List<Flight> GetAllFlight();

        string GetAllAirportNames();
        List<Airport> GetAllAirport();
        string CreateFlight(Flight entity);

        void UpdateFlight(Flight entity);

        void DeleteFlight(Flight flight);
        Airport GetAirportById(int id);
        List<double> GetCoordinate(string Airport);
    }
        
}