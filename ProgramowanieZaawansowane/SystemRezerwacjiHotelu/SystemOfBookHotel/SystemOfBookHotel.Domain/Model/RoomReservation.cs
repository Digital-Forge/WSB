using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SystemOfBookHotel.Domain.Model
{
    public class RoomReservation
    {
        [Key]
        public int Id { get; set; }
        public int CountOld { get; set; }
        public int CountChild { get; set; }
        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual ICollection<PerkToRoom> PerksToRooms { get; set; }
    }
}
