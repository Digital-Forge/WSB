using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemOfBookHotel.Infrastructure.Migrations
{
    public partial class fs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerRef",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_CustomerRef",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "CustomerRef",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "CustomerRef",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerRef",
                table: "Reservations",
                column: "CustomerRef",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerRef",
                table: "Reservations",
                column: "CustomerRef",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
