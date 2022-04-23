using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemOfBookHotel.Domain.Model;

namespace SystemOfBookHotel.Domain.Interface
{
    public interface IRoomRepository
    {
        void DeleteRoom(int id);
        int AddRoom(string number, int capacity = 4);        
        IQueryable<Room> GetRoomList();        
        IQueryable<Room> GetFreeRoomListInTerm(DateTime start, DateTime end);        
        Room GetRoomById(int id);
        Room GetRoomByNumber(string number);
    }
}
