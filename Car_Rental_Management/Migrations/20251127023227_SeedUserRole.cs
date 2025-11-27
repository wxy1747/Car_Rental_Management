using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_Rental_Management.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f2f5a689-ff70-4e57-ab66-a5de1c67c7c9", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENH23GcACWpGcnNALHpKdbNSa+qf0YNCe8jpdhMOcruJ3e43RR84f3CSx9CFwAs51w==", null, false, "d3cb7cd9-8c64-4b57-b400-030eeaf7970d", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5043), new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5058), new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5355), new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5359), new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5527), new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5530), new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5532), new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5535), new DateTime(2025, 11, 27, 10, 32, 25, 802, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2299), new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2314), new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2534), new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2535), new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2614), new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2616), new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2617), new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2619), new DateTime(2025, 11, 27, 10, 22, 36, 216, DateTimeKind.Local).AddTicks(2619) });
        }
    }
}
