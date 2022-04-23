using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemOfBookHotel.Domain.Model;

namespace SystemOfBookHotel.Domain.Interface
{
    public interface IReservationRepository
    {
        void AddReservationCustomer(Customer customer, Reservation reservation);
        void AddRoomReservatiom(Reservation reservation, RoomReservation roomReservation);
        void SetRoomToReservatiom(int roomReservationId, int roomId);
        void SetExtraPerkToReservatiom(int roomReservationId, int perkId);
        IQueryable<RoomReservation> GetRoomReservationById(int Id);
        IQueryable<RoomReservation> GetReservationRoomListFromTerm(DateTime term);
        void DeleteRoomReservation(int roomReservationId);
    }
}
