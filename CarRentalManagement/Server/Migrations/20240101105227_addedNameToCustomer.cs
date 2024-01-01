using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedNameToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a97bcb6d-e062-43de-8c0e-db7d6279eaaa", "AQAAAAIAAYagAAAAELGcMFMoNBUf/1R0kaP6Iu5IzPsLi2YMPonTEFr4bHoaEvtZXHld8KWazPZmfejreA==", "57d9b115-c063-4840-9c53-420d8fae160c" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4255), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4270), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4561), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4563), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4735), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4737), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4738), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 1, 1, 18, 52, 27, 109, DateTimeKind.Local).AddTicks(4740) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8e75f08-5306-4638-9f46-78a032e63189", "AQAAAAIAAYagAAAAEEPD1h1ohdJKoJMy8vB5scasR1bWF5lGueshk/7sEvpqqEf25Ni9CKWyebaQv07wGg==", "059895ae-99e8-4d48-a73e-269abccaf7b5" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(8989), new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9007), new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9295), new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9297), new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9473), new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9478), new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9479), new DateTime(2024, 1, 1, 18, 42, 4, 170, DateTimeKind.Local).AddTicks(9480) });
        }
    }
}
