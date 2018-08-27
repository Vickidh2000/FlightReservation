using FlightReservartion.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation.Business
{
    public class FlightServices : IFlightServices
    {
        private readonly IFlightRepository _flightRepository;


        public FlightServices(IFlightRepository flightRepository)
        {
            this._flightRepository = flightRepository;

        }

        public Flight GetFlightById(string id)
        {
            return _flightRepository.GetFlightById(id);
        }


        public string GetAllAirportNames()
        {
           
           return _flightRepository.GetAllAirportNames();
            
        }

        public List<Flight> GetFlight()
        {
            return _flightRepository.GetAllFlight().ToList();
        }

        public string CreateFlight(Flight entity)
        {
            return _flightRepository.CreateFlight(entity);
        }

        public void UpdateFlight (Flight entity)
        {
            _flightRepository.UpdateFlight(entity);
        }

        public void RemoveFlight(Flight flight)
        {
            _flightRepository.DeleteFlight(flight);
        }

        //  Summary
        // First element Latidude , second element Longitude
        //
        public List<double> GetCoordinate(string Airport)
        {
           return _flightRepository.GetCoordinate(Airport);
        }


    }
}
