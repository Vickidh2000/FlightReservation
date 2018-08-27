using FlightReservartion.DAL;
using FlightReservation.Business;
using FlightReservationWebApiServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Unity.Attributes;

namespace FlightReservationWebApiServices.Controllers
{
    public class FilghtsController : ApiController
    {
        private IFlightRepository _flightRepository;
        private IFlightServices _flightServices;

        public FilghtsController()
        {

        }

        [InjectionConstructor]
        public FilghtsController (IFlightRepository flightRepository, IFlightServices flightServices)
        {
            _flightRepository = flightRepository;
            _flightServices  = flightServices;
        }
    // GET: api/Filghts
       public IEnumerable<object> Get()
        {

            var res = _flightServices.GetFlight()
                .ToList()
                .Select(f => new FlightModel
                {
                    Departure = f.Departure,
                    Destination = f.Destination,
                    Distance = f.Distance,
                    FuelConsumption = f.FuelConsumption

                });

            return res;
        }

        // GET: api/Filghts/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Filghts

        public void Post([FromBody]Flight flight)
        {
            
            
        }

        // PUT: api/Filghts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Filghts/5
        public void Delete(int id)
        {
        }
    }
}
