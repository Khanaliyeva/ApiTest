using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiIntro.Migrations
{
    public partial class createdbandaddtablesad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_brands_BrandId",
                table: "cars");

            migrationBuilder.DropForeignKey(
                name: "FK_cars_colors_ColorId",
                table: "cars");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "colors",
                newName: "colorName");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "cars",
                newName: "ColorID");

            migrationBuilder.RenameIndex(
                name: "IX_cars_ColorId",
                table: "cars",
                newName: "IX_cars_ColorID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModelYear",
                table: "cars",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ColorID",
                table: "cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_brands_BrandId",
                table: "cars",
                column: "BrandId",
                principalTable: "brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_colors_ColorID",
                table: "cars",
                column: "ColorID",
                principalTable: "colors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_brands_BrandId",
                table: "cars");

            migrationBuilder.DropForeignKey(
                name: "FK_cars_colors_ColorID",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "cars");

            migrationBuilder.RenameColumn(
                name: "colorName",
                table: "colors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ColorID",
                table: "cars",
                newName: "ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_cars_ColorID",
                table: "cars",
                newName: "IX_cars_ColorId");

            migrationBuilder.AlterColumn<int>(
                name: "ModelYear",
                table: "cars",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
