﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class OrderColumnAddedIntoSlidersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Sliders",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Sliders");
        }
    }
}
