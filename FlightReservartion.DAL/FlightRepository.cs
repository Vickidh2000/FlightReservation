using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservartion.DAL
{
    public class FlightRepository : IFlightRepository
    {

        public Flight GetFlightById(string id)
        {
            using (FlightReservationEntities db = new FlightReservationEntities())
            {
                return db.Flights.Where(x => x.Departure == id).FirstOrDefault();
            }


        }

        public string GetAllAirportNames()
        {
            using (FlightReservationEntities db = new FlightReservationEntities())
            {
                return db.Airports.FirstOrDefault().Name;
            }
        }

        public List<Flight> GetAllFlight()
        {
            using (FlightReservationEntities db = new FlightReservationEntities())
            {
                return db.Flights.ToList();
            }
        }

        public string CreateFlight(Flight entity)
        {
            
            using (FlightReservationEntities db = new FlightReservationEntities())
            {
                 db.Set<Flight>().Add(entity);
                 db.SaveChanges();
            }
            return entity.Flight_id;
        }


        public void UpdateFlight(Flight entity)
        {
            using (FlightReservationEntities db = new FlightReservationEntities())
            {

                db.Entry<Flight>(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteFlight(Flight flight)
        {
            using (FlightReservationEntities db = new FlightReservationEntities())
            {
                db.Set<Flight>().Remove(flight);
            }
        }

        public List<Airport> GetAllAirport()
        {
            using (FlightReservationEntities db = new FlightReservationEntities())
            {
               return db.Airports.ToList();
            }

        }

        public Airport GetAirportById(int id)
        {
            using (FlightReservationEntities db = new FlightReservationEntities())
            {
                return db.Airports.Where(x=>x.Airport_id == id ).FirstOrDefault();
            }

        }

        public List<double> GetCoordinate(string  Airport)
        {
            using (FlightReservationEntities db = new FlightReservationEntities())
            {
                var Query = from a in db.Airports
                            where a.Name == Airport
                            select new { a.Latitude, a.Longitude };
                List<double> Coordinates = new List<double>();

                foreach (var res in Query)
                {
                    Coordinates.Add(res.Latitude);
                    Coordinates.Add(res.Longitude);
                }
                return Coordinates;
            }
        }

    }
}
