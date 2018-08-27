using FlightReservartion.DAL;

using System.Collections.Generic;

namespace FlightReservation.Business
{
    public interface IReservationServices
    {
        Reservation GetReservById(int id);
        List<Reservation> GetReservations();
        int CreateReservation(Reservation reservation);

    }  
}