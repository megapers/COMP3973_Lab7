using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab7.Migrations
{
    public partial class SeedParties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Party",
                columns: new[] { "PartyId", "ExpectedNumberOfGuests", "Location", "PartyDate", "PartyName" },
                values: new object[] { 1, 30, "Zanzibar", new DateTime(1930, 3, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), "Birthday" });

            migrationBuilder.InsertData(
                table: "Party",
                columns: new[] { "PartyId", "ExpectedNumberOfGuests", "Location", "PartyDate", "PartyName" },
                values: new object[] { 2, 25, "Zanzibar", new DateTime(1935, 5, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), "DayCare Graduation" });

            migrationBuilder.InsertData(
                table: "Party",
                columns: new[] { "PartyId", "ExpectedNumberOfGuests", "Location", "PartyDate", "PartyName" },
                values: new object[] { 3, 40, "Zanzibar", new DateTime(1952, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "High School Graduation" });

            migrationBuilder.InsertData(
                table: "Party",
                columns: new[] { "PartyId", "ExpectedNumberOfGuests", "Location", "PartyDate", "PartyName" },
                values: new object[] { 4, 140, "Dar al-Salam", new DateTime(1960, 11, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), "Wedding" });

            migrationBuilder.InsertData(
                table: "Party",
                columns: new[] { "PartyId", "ExpectedNumberOfGuests", "Location", "PartyDate", "PartyName" },
                values: new object[] { 5, 50, "Dar al-Salam", new DateTime(1965, 2, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Birth of son" });

            migrationBuilder.InsertData(
                table: "Party",
                columns: new[] { "PartyId", "ExpectedNumberOfGuests", "Location", "PartyDate", "PartyName" },
                values: new object[] { 6, 55, "Santo Domingo", new DateTime(1972, 8, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), "Major job promotion" });

            migrationBuilder.InsertData(
                table: "Party",
                columns: new[] { "PartyId", "ExpectedNumberOfGuests", "Location", "PartyDate", "PartyName" },
                values: new object[] { 7, 60, "Santo Domingo", new DateTime(1995, 11, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), "Birth of grandaughter" });

            migrationBuilder.InsertData(
                table: "Party",
                columns: new[] { "PartyId", "ExpectedNumberOfGuests", "Location", "PartyDate", "PartyName" },
                values: new object[] { 8, 27, "Santo Domingo", new DateTime(2000, 3, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), "Retirement party" });

            migrationBuilder.InsertData(
                table: "Party",
                columns: new[] { "PartyId", "ExpectedNumberOfGuests", "Location", "PartyDate", "PartyName" },
                values: new object[] { 9, 120, "Santo Domingo", new DateTime(2012, 9, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Funeral" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Party",
                keyColumn: "PartyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Party",
                keyColumn: "PartyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Party",
                keyColumn: "PartyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Party",
                keyColumn: "PartyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Party",
                keyColumn: "PartyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Party",
                keyColumn: "PartyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Party",
                keyColumn: "PartyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Party",
                keyColumn: "PartyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Party",
                keyColumn: "PartyId",
                keyValue: 9);
        }
    }
}
