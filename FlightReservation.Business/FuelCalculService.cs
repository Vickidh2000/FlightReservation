using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation.Business
{
    public static class FuelCalculService
    {
        public static double FuelCalculation(double distance)
        {
            var kgByKm = Constants.FUEL_CONSUMPTION_IN_KG_BY_HOUR / Constants.KM_FLIGHT_BY_HOUR;
            var EuroByKm = kgByKm * Constants.FUEL_PRICE_IN_EURO_BY_KG;

            return EuroByKm * distance;
        }        
                
    }
}
