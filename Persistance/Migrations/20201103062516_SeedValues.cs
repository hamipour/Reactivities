using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class SeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "Summary", "TemperetureC", "TemperetureF", "WeatherDate" },
                values: new object[] { 1, "windy", 20, 50, new DateTime(2020, 11, 3, 9, 55, 16, 353, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "Summary", "TemperetureC", "TemperetureF", "WeatherDate" },
                values: new object[] { 2, "fogy", 15, 30, new DateTime(2020, 11, 3, 9, 55, 16, 360, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "Summary", "TemperetureC", "TemperetureF", "WeatherDate" },
                values: new object[] { 3, "freezing", 5, 20, new DateTime(2020, 11, 3, 9, 55, 16, 360, DateTimeKind.Local).AddTicks(2629) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
