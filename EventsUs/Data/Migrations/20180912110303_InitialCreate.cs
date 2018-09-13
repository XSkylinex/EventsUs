using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsUs.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numOfEvents",
                table: "Event",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numOfEvents",
                table: "Event");
        }
    }
}
