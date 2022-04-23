using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemOfBookHotel.Infrastructure.Migrations
{
    public partial class smallchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomReservations_Rooms_RoomId",
                table: "RoomReservations");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "RoomReservations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomReservations_Rooms_RoomId",
                table: "RoomReservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomReservations_Rooms_RoomId",
                table: "RoomReservations");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "RoomReservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomReservations_Rooms_RoomId",
                table: "RoomReservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
