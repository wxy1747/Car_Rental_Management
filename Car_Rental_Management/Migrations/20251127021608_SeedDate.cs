using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_Rental_Management.Migrations
{
    /// <inheritdoc />
    public partial class SeedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8501), new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8523), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8527), new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8527), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8861), new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8861), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8863), new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8863), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8947), new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8947), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8949), new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8949), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8950), new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8951), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8952), new DateTime(2025, 11, 27, 10, 16, 6, 953, DateTimeKind.Local).AddTicks(8953), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
