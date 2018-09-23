using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsUs.Migrations
{
    public partial class publicPrivate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PublicPrivate",
                table: "Event",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicPrivate",
                table: "Event");
        }
    }
}
