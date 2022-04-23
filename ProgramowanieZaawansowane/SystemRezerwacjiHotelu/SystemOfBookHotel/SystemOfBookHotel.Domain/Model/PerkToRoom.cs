using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Domain.Model
{
    public class PerkToRoom
    {
        public int ExtraPerkId { get; set; }
        public ExtraPerk ExtraPerk { get; set; }
        public int RoomReservationId { get; set; }
        public RoomReservation RoomReservation { get; set; }
    }
}
