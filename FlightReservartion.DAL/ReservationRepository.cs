using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservartion.DAL
{
    public class ReservationRepository: IReservationRepository
    {
        public Reservation GetReservationById(int id)
        {
            using (FlightReservationEntities db = new FlightReservationEntities())
            {
                return db.Reservations.Where(x => x.Reservation_id == id).FirstOrDefault();
            }
        }
        public List<Reservation> GetAllReservation()
        {
            using (FlightReservationEntities db = new FlightReservationEntities())
            {
                return db.Reservations.ToList();
            }
        }

        public int CreateReservation (Reservation entity)
        {
            using (FlightReservationEntities db = new FlightReservationEntities())
            {
                db.Set<Reservation>().Add(entity);
                db.SaveChanges();
            }
            return entity.Reservation_id;
        }
    }
}
