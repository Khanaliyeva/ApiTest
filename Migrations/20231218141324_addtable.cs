using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiIntro.Migrations
{
    public partial class addtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_cars_BrandId",
                table: "cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_cars_ColorId",
                table: "cars",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_brands_BrandId",
                table: "cars",
                column: "BrandId",
                principalTable: "brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cars_colors_ColorId",
                table: "cars",
                column: "ColorId",
                principalTable: "colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_brands_BrandId",
                table: "cars");

            migrationBuilder.DropForeignKey(
                name: "FK_cars_colors_ColorId",
                table: "cars");

            migrationBuilder.DropIndex(
                name: "IX_cars_BrandId",
                table: "cars");

            migrationBuilder.DropIndex(
                name: "IX_cars_ColorId",
                table: "cars");
        }
    }
}
