using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Application.ViewModel
{
    public class ListOfRoomVM
    {
        public List<RoomVM> Rooms { get; set; }
        public bool RoomOut { get; set; } = false;
        public int ToRemove { get; set; } = 0;
        public DateReservationVM Dates { get; set; }
    }
}
