using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Application.ViewModel
{
    public class ListOfRoomPerkVM
    {
        public List<RoomPerkVM> ListRooms { get; set; }
        public DateReservationVM Dates { get; set; }
        public ClientDataVM ClientData { get; set; }
    }
}
