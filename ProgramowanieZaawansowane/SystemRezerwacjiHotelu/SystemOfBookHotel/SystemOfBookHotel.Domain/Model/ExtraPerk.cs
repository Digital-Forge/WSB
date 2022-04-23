using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SystemOfBookHotel.Domain.Model
{
    public class ExtraPerk
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Personal { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<PerkToRoom> PerksToRooms { get; set; }
    }
}
