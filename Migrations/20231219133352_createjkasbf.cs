using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiIntro.Migrations
{
    public partial class createjkasbf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "brands",
                newName: "brandName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "brandName",
                table: "brands",
                newName: "Name");
        }
    }
}
