using System.Collections.Generic;

namespace FlightReservartion.DAL
{
    public interface IReservationRepository
    {
        Reservation GetReservationById(int id);

        List<Reservation> GetAllReservation();

        int CreateReservation(Reservation entity);
       
    }
}