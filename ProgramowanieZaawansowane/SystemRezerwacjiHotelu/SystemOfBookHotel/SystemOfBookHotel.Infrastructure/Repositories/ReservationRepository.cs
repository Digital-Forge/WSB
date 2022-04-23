using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SystemOfBookHotel.Domain.Interface;
using SystemOfBookHotel.Domain.Model;

namespace SystemOfBookHotel.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly Context _context;

        public ReservationRepository(Context context)
        {
            _context = context;
        }

        public void AddReservationCustomer(Customer customer, Reservation reservation)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            reservation.CustomerId = customer.Id;
            _context.Reservations.Add(reservation); 
            _context.SaveChanges();
        }

        public void AddRoomReservatiom(Reservation reservation, RoomReservation roomReservation)
        {
            roomReservation.ReservationId = _context.Reservations.Where(x => x.Id == reservation.Id).FirstOrDefault().Id;
            _context.RoomReservations.Add(roomReservation);
            _context.SaveChanges();
        }

        public void SetRoomToReservatiom(int roomReservationId, int roomId)
        {
            _context.RoomReservations.Where(x => x.Id == roomReservationId).FirstOrDefault().RoomId = _context.Rooms.Where(x => x.Id == roomId).FirstOrDefault().Id;
            _context.SaveChanges();
        }

        public void SetExtraPerkToReservatiom(int roomReservationId, int perkId)
        {
            _context.PerksToRooms.Add(new PerkToRoom
            {
                ExtraPerkId = perkId,
                RoomReservationId = roomReservationId
            });
            _context.SaveChanges();
        }

        public IQueryable<RoomReservation> GetRoomReservationById(int Id)
        {
            return _context.RoomReservations.Where(x => x.Id == Id);
        }

        public IQueryable<RoomReservation> GetReservationRoomListFromTerm(DateTime term)
        {
            return _context.Reservations.Where(x => x.Stop >= term).SelectMany(x => x.RoomReservations);
        }

        public void DeleteRoomReservation(int roomReservationId)
        {
            _context.PerksToRooms.RemoveRange(_context.PerksToRooms.Where(x => x.RoomReservationId == roomReservationId).ToList());

            if (_context.RoomReservations.Where(x => x.Id == roomReservationId).Select(x => x.Reservation.RoomReservations.Count).FirstOrDefault() == 1)
            {
                _context.Customers
                    .Remove(_context.RoomReservations
                        .Where(x => x.Id == roomReservationId)
                        .Select(x => x.Reservation.Customer).FirstOrDefault());
                _context.Reservations
                    .Remove(_context.RoomReservations
                        .Where(x => x.Id == roomReservationId)
                        .Select(x => x.Reservation).FirstOrDefault());
            }
            else
            {
                _context.RoomReservations
                    .Remove(_context.RoomReservations
                        .Where(x => x.Id == roomReservationId).FirstOrDefault());
            }
            _context.SaveChanges();
        }
    }
}
