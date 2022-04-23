using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SystemOfBookHotel.Domain.Model
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NumberRoom { get; set; }
        [Required]
        public int Capacity { get; set; }
        public virtual ICollection<RoomReservation> RoomReservation { get; set; }
    }
}
