using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class AddNewPropertyNoEntytiesProjectClientDeveloper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Developers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "Age",
                table: "Clients",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Clients");
        }
    }
}
