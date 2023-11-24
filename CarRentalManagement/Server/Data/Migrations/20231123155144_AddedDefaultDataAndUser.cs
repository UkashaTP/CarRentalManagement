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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "5d355cbc-e725-487d-ad37-1cb3b890a1c4", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGwONNqgfLTgM1qjy2oY07rR/TtlexFVaJU9mY7voJVRYR19ipL0YOTB2hbbrLwVGA==", null, false, "8b08680d-2594-4788-b7b1-2e4e9534e5fb", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8349), new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8364), new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8683), new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8685), new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 11, 23, 23, 51, 44, 506, DateTimeKind.Local).AddTicks(8864) });

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

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6030), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6453), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6650), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6652), new DateTime(2023, 11, 22, 11, 49, 46, 212, DateTimeKind.Local).AddTicks(6652) });
        }
    }
}
