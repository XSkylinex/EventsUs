using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsUs.Migrations
{
    public partial class FindFriends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "FindFriends",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LockoutEnd",
                table: "FindFriends",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "FindFriends",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "FindFriends",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "FindFriends");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "FindFriends");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "FindFriends");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "FindFriends");
        }
    }
}
