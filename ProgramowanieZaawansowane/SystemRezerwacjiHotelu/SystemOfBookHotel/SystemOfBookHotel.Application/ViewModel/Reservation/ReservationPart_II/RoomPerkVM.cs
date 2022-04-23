using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Application.ViewModel
{
    public class RoomPerkVM
    {
        public RoomVM Room { get; set; }
        public List<PerkVM> PerkList { get; set; }
    }
}
