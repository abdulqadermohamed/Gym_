using Microsoft.EntityFrameworkCore.Migrations;

namespace Gym_.Migrations
{
    public partial class EditTableSubscriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "TypeOfDuration",
                table: "Subscriptions");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "UserSubscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "UserSubscriptions");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfDuration",
                table: "Subscriptions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
