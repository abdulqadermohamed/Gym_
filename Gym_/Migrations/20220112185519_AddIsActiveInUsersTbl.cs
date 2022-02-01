using Microsoft.EntityFrameworkCore.Migrations;

namespace Gym_.Migrations
{
    public partial class AddIsActiveInUsersTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "UserSubscriptions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "UserSubscriptions");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");
        }
    }
}
