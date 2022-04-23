﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemOfBookHotel.Infrastructure.Migrations
{
    public partial class changeperk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ExtraPerks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ExtraPerks");
        }
    }
}
