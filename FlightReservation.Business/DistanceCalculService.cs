using System.Device.Location;

namespace FlightReservation.Business
{
    public static class DistanceCalculService
    {
        public static double CalculDistance(double lat1, double lon1, double lat2, double lon2)
        {

            var sCoord = new GeoCoordinate(lat1, lon1);
            var eCoord = new GeoCoordinate(lat2, lon2);


            return sCoord.GetDistanceTo(eCoord);
            
        }
    }
      
}
