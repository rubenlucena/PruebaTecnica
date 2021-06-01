using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaTecnica.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Edited", "Gender", "Height", "HomeWorld", "Name", "Specie" },
                values: new object[] { 1, new DateTime(2021, 5, 31, 21, 34, 54, 228, DateTimeKind.Utc).AddTicks(6806), new DateTime(2021, 5, 31, 21, 34, 54, 228, DateTimeKind.Utc).AddTicks(7065), null, 172, "Tatooine", "Luke Skywalker", "Human" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Edited", "Gender", "Height", "HomeWorld", "Name", "Specie" },
                values: new object[] { 2, new DateTime(2021, 5, 31, 21, 34, 54, 228, DateTimeKind.Utc).AddTicks(7324), new DateTime(2021, 5, 31, 21, 34, 54, 228, DateTimeKind.Utc).AddTicks(7336), null, 167, "Tatooine", "C-3PO", "Droid" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Edited", "Gender", "Height", "HomeWorld", "Name", "Specie" },
                values: new object[] { 3, new DateTime(2021, 5, 31, 21, 34, 54, 228, DateTimeKind.Utc).AddTicks(7342), new DateTime(2021, 5, 31, 21, 34, 54, 228, DateTimeKind.Utc).AddTicks(7343), null, 150, "Alderaan", "Leia Organa", "Human" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
