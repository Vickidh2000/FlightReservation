using FlightReservartion.DAL;
using FlightReservation.Business;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FlightReservation.Presentation.Controllers
{
    public class FlightController : Controller
    {

        private IFlightServices _flightService;

        

        public FlightController(IFlightServices flightService)
        {
            this._flightService = flightService;
            
        }


        public string Baseurl = "http://localhost:50773/";

        // GET: Flight
        public async Task<ActionResult> Index()
        {

           List<Flight> flightS = new List<Flight>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                
                HttpResponseMessage Res = await client.GetAsync("api/Filghts");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var FlightResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Flight list  
                    flightS = JsonConvert.DeserializeObject<List<Flight>>(FlightResponse);

                }
                //returning the employee list to view  
                return View(flightS);
            }
        }

        // GET: Flight/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Flight/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flight/Create
        [HttpPost]
        public  ActionResult Create(Flight flight)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    flight.Flight_id = Guid.NewGuid().ToString();

                    var DepartureCoord = _flightService.GetCoordinate(flight.Departure);

                    var DestinationCoord = _flightService.GetCoordinate(flight.Destination);

                    var Distance = DistanceCalculService.CalculDistance(DepartureCoord[0],
                    DepartureCoord[1], DestinationCoord[0], DestinationCoord[1]);


                    flight.Distance = (decimal?)Distance / 1000;


                    flight.FuelConsumption = (decimal?)FuelCalculService.FuelCalculation(Distance / 1000);


                    _flightService.CreateFlight(flight);

                    //ViewBag.Departure = _flightService.GetAllAirportNames();

                    return RedirectToAction("Index");
                }
                return View(flight);
            }
            catch
            {
                return View();
            }

        }
        

        // GET: Flight/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var flight =  _flightService.GetFlightById(id);
           
            if (flight == null)
            {
                return HttpNotFound();
            }
            
            return View(flight);
        }

       

        // POST: Flight/Edit/5
        [HttpPost]
        public ActionResult Edit(Flight flight)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _flightService.UpdateFlight(flight);
                    
                    return RedirectToAction("Index");
                }
                return View(flight);
            }
            catch
            {
                return View();
            }
        }

        // GET: Flight/Delete/5
        public ActionResult Delete(string id)
        {
            var flight = _flightService.GetFlightById(id);

            if (flight == null)
            {
                return HttpNotFound();
            }
            
            return View(flight);
         
        }

        // POST: Flight/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, Flight flight)
        {
            try
            {
                

                flight = _flightService.GetFlightById(id);

                if (flight == null)
                {
                    return HttpNotFound();
                }
                _flightService.RemoveFlight(flight);

                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                var ex = e.Message;
                return View();
            }
        }
    }
}
