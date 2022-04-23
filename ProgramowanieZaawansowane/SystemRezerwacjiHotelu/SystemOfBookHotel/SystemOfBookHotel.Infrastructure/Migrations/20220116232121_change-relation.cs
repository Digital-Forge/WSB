using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemOfBookHotel.Infrastructure.Migrations
{
    public partial class changerelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoomReservations_RoomId",
                table: "RoomReservations");

            migrationBuilder.CreateIndex(
                name: "IX_RoomReservations_RoomId",
                table: "RoomReservations",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoomReservations_RoomId",
                table: "RoomReservations");

            migrationBuilder.CreateIndex(
                name: "IX_RoomReservations_RoomId",
                table: "RoomReservations",
                column: "RoomId",
                unique: true);
        }
    }
}
