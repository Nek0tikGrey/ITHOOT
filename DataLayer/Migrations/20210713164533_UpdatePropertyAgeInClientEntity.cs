using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class UpdatePropertyAgeInClientEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Clients",
                type: "int",
                nullable: false,
                oldClrType: typeof(ushort),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<ushort>(
                name: "Age",
                table: "Clients",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
