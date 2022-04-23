using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Application.ViewModel
{
    public class AdmReservationDetals
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string RoomName { get; set; }
        public int CountAdult { get; set; }
        public int CountChild { get; set; }
        public List<string> ExtraPerk { get; set; } = new List<string>();
    }
}
