using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemOfBookHotel.Infrastructure.Migrations
{
    public partial class changeandextend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Personal",
                table: "ExtraPerks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "ExtraPerks",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "ProgramSettings",
                columns: table => new
                {
                    Currency = table.Column<string>(nullable: true),
                    PriceForRoom = table.Column<double>(nullable: false),
                    ChildConcession = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramSettings");

            migrationBuilder.DropColumn(
                name: "Personal",
                table: "ExtraPerks");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ExtraPerks");
        }
    }
}
