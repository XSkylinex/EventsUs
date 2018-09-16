using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsUs.Data.Migrations
{
    public partial class initial3423423 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Private",
            //    table: "Event");

            migrationBuilder.AddColumn<string>(
                name: "YoutubeId",
                table: "Event",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YoutubeId",
                table: "Event");

            //migrationBuilder.AddColumn<bool>(
            //    name: "Private",
            //    table: "Event",
            //    nullable: false,
            //    defaultValue: false);
        }
    }
}
