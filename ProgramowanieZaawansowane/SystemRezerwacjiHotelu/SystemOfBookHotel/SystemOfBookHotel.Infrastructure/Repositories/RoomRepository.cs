using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemOfBookHotel.Domain.Interface;
using SystemOfBookHotel.Domain.Model;

namespace SystemOfBookHotel.Infrastructure.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly Context _context;

        public RoomRepository(Context context)
        {
            _context = context;
        }

        public void DeleteRoom(int id)
        {
            var item = _context.Rooms.Find(id);
            if (item != null)
            {
                _context.Rooms.Remove(item);
                _context.SaveChanges();
            }
        }

        public int AddRoom(string number,int capacity = 4)
        {
            var item = new Room { NumberRoom = number, Capacity = capacity };
            _context.Rooms.Add(item);
            return item.Id;
        }

        public IQueryable<Room> GetRoomList()
        {
            return _context.Rooms;
        }

        public Room GetRoomById(int id)
        {
            return _context.Rooms.Where(x => x.Id == id).FirstOrDefault();
        }

        public Room GetRoomByNumber(string number)
        {
            return _context.Rooms.Where(x => x.NumberRoom.ToLower() == number.ToLower()).FirstOrDefault();
        }

        public IQueryable<Room> GetFreeRoomListInTerm(DateTime start, DateTime end)
        {
            return _context.Rooms
                .Where(x => x.RoomReservation.Count == 0 
                   || !x.RoomReservation
                           .Where(y => y.Reservation.Start <= end.AddDays(1) 
                               || y.Reservation.Stop >= start.AddDays(-1))
                                    .Any());
        }
    }
}
