using FlightReservartion.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation.Business
{
    public class ReservationServices : IReservationServices
    {
        private readonly IReservationRepository _reservationrepository ;

        public ReservationServices( IReservationRepository reservationrepository)
        {          
            this._reservationrepository = reservationrepository;
         
        }

        public Reservation GetReservById(int id)
        {
            return _reservationrepository.GetReservationById(id);
        }

        public List<Reservation> GetReservations()
        {
            return _reservationrepository.GetAllReservation().ToList();
        }

        public int CreateReservation(Reservation reservation)
        {
            return _reservationrepository.CreateReservation(reservation);
            
        }
        
     
    }
}
