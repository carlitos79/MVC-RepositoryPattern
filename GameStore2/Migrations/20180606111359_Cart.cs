using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GameStore2.Migrations
{
    public partial class Cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartGameID",
                table: "Cart",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CartGameTitle",
                table: "Cart",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CartGameUnitPrice",
                table: "Cart",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartGameID",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "CartGameTitle",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "CartGameUnitPrice",
                table: "Cart");
        }
    }
}
