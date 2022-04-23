using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Application.ViewModel
{
    public class SummaryRoomVM
    {
        public int RoomId { get; set; }
        public int CountOld { get; set; }
        public int CountChild { get; set; }
        public string PriceForRoom { get; set; }
        public List<PerkVM> PerkList { get; set; }
        public string PriceForPerks { get; set; }
    }
}
