using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemOfBookHotel.Infrastructure.Migrations
{
    public partial class mail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EnableSSL",
                table: "ProgramSettings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HostSmtp",
                table: "ProgramSettings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Port",
                table: "ProgramSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SenderEmail",
                table: "ProgramSettings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderEmailPassword",
                table: "ProgramSettings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderName",
                table: "ProgramSettings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnableSSL",
                table: "ProgramSettings");

            migrationBuilder.DropColumn(
                name: "HostSmtp",
                table: "ProgramSettings");

            migrationBuilder.DropColumn(
                name: "Port",
                table: "ProgramSettings");

            migrationBuilder.DropColumn(
                name: "SenderEmail",
                table: "ProgramSettings");

            migrationBuilder.DropColumn(
                name: "SenderEmailPassword",
                table: "ProgramSettings");

            migrationBuilder.DropColumn(
                name: "SenderName",
                table: "ProgramSettings");
        }
    }
}
