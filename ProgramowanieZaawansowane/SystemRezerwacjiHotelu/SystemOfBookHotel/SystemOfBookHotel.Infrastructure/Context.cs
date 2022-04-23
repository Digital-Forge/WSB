using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SystemOfBookHotel.Domain.Model;

namespace SystemOfBookHotel.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ExtraPerk> ExtraPerks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<PerkToRoom> PerksToRooms { get; set; }
        public DbSet<ProgramSetting> ProgramSettings { get; set; }

        public Context(DbContextOptions options) : base(options) 
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Set Property character

            builder.Entity<Room>()
                .HasIndex(x => x.NumberRoom)
                .IsUnique();

            builder.Entity<ProgramSetting>()
                .HasNoKey();

            // Relations

            builder.Entity<Customer>()
                .HasOne<Reservation>(x => x.Reservation)
                .WithOne(y => y.Customer)
                .HasForeignKey<Reservation>(z => z.CustomerId);

            builder.Entity<RoomReservation>()
                .HasOne<Reservation>(x => x.Reservation)
                .WithMany(y => y.RoomReservations)
                .HasForeignKey(z => z.ReservationId);

            builder.Entity<RoomReservation>()
                .HasOne<Room>(x => x.Room)
                .WithMany(y => y.RoomReservation)
                .HasForeignKey(z => z.RoomId);

            builder.Entity<PerkToRoom>().HasKey(x => new { x.RoomReservationId, x.ExtraPerkId });

            builder.Entity<PerkToRoom>()
                .HasOne<RoomReservation>(x => x.RoomReservation)
                .WithMany(y => y.PerksToRooms)
                .HasForeignKey(z => z.RoomReservationId);


            builder.Entity<PerkToRoom>()
                .HasOne<ExtraPerk>(x => x.ExtraPerk)
                .WithMany(y => y.PerksToRooms)
                .HasForeignKey(z => z.ExtraPerkId);
        }
    }
}
