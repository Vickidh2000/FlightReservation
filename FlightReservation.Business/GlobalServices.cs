using FlightReservartion.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation.Business
{
    public class GlobalServices : IGlobalServices
    {
        private IFlightRepository _flyrepository;

     //   private IPassengerRepository _passengerrepository;

        private IReservationRepository _reservationrepository;
              


        public GlobalServices(IFlightRepository flyrepository,
             IReservationRepository reservationrepository)
        {
            this._flyrepository = flyrepository;
          //  this._passengerrepository = passengerrepository;
            this._reservationrepository = reservationrepository;
        }

        public  Flight GetFlightById(string id)
        {
            return  _flyrepository.GetFlightById(id);
        }

        public Reservation GetReserById(int id)
        {
            return _reservationrepository.GetReservationById(id);
        }

       
    }
  
}
