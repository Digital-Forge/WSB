using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Application.ViewModel
{
    public class SummaryVM
    {
        public DateReservationVM Dates { get; set; }
        public ClientDataVM CustomerData { get; set; }
        public List<SummaryRoomVM> Rooms { get; set; }
        public string TotalPrice { get; set; }
        public double _TotalPrice { get; set; }
    }
}
