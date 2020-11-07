using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class ActivityEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Venue = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 1,
                column: "WeatherDate",
                value: new DateTime(2020, 11, 6, 18, 42, 0, 812, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 2,
                column: "WeatherDate",
                value: new DateTime(2020, 11, 6, 18, 42, 0, 816, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 3,
                column: "WeatherDate",
                value: new DateTime(2020, 11, 6, 18, 42, 0, 816, DateTimeKind.Local).AddTicks(183));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.UpdateData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 1,
                column: "WeatherDate",
                value: new DateTime(2020, 11, 3, 9, 55, 16, 353, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 2,
                column: "WeatherDate",
                value: new DateTime(2020, 11, 3, 9, 55, 16, 360, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 3,
                column: "WeatherDate",
                value: new DateTime(2020, 11, 3, 9, 55, 16, 360, DateTimeKind.Local).AddTicks(2629));
        }
    }
}
