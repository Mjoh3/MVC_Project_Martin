using Microsoft.EntityFrameworkCore.Migrations;

namespace MartinWebApp.Migrations
{
    public partial class UPdating1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cityname",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Languagename",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cityname",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Languagename",
                table: "People");
        }
    }
}
