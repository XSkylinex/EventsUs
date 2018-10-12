using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsUs.Migrations
{
    public partial class inifew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Predictpepole",
                table: "Event",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Predictpepole",
                table: "Event",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
