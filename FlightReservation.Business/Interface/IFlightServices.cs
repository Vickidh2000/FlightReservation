using FlightReservartion.DAL;
using System.Collections.Generic;

namespace FlightReservation.Business
{
    public interface IFlightServices
    {
        Flight GetFlightById(string id);
        List<Flight> GetFlight();
        string CreateFlight(Flight entity);
        void UpdateFlight(Flight entity);
        void RemoveFlight(Flight flight);
        string GetAllAirportNames();
        List<double> GetCoordinate(string Airport);
    }
}