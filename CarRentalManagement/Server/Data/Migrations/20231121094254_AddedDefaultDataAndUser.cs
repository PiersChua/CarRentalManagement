using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3066bdac-95b5-4b60-8014-f80f353501cd", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIQ9YevO1qjTVDS3h9cI5fEOtv8qdOXN07yYqCbN76SJGqAUPYbqJX3QdGJZy7f7hw==", null, false, "7f61701e-8afa-40c4-a394-c07f9094e591", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(6981), new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(6997), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(7002), new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(7003), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(7731), new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(7734), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(7738), new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(7738), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(8148), new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(8149), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(8152), new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(8153), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(8157), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(8160), new DateTime(2023, 11, 21, 17, 42, 53, 849, DateTimeKind.Local).AddTicks(8161), "Rav4", "System" }
                });

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
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
