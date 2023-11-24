using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6030), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6049), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6053), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6453), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6453), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6456), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6647), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6649), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6650), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6650), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6652), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6652), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
