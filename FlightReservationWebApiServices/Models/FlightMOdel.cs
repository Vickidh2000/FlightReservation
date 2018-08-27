using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightReservationWebApiServices.Models
{
    public class FlightModel
    {
        public string Flight_id { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public Nullable<decimal> Distance { get; set; }
        public Nullable<decimal> FuelConsumption { get; set; }
        public Nullable<decimal> Number_of_Adult { get; set; }
        public Nullable<decimal> Number_of_Children { get; set; }
        public Nullable<decimal> Time { get; set; }
    }
}