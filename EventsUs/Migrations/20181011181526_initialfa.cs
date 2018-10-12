using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsUs.Migrations
{
    public partial class initialfa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Predictpepole",
                table: "Event",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Predictpepole",
                table: "Event");
        }
    }
}
