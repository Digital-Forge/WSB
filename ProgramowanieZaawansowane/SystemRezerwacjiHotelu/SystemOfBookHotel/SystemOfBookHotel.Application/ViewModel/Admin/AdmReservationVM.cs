using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Application.ViewModel
{
    public class AdmReservationVM
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string RoomNumber { get; set; }
        public string Email { get; set; }
        public int RoomReservationId { get; set; }
    }
}
