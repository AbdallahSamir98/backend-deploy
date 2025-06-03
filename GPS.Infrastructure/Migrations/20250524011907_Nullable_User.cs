using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProjecrStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Nullable_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("81232751-9ff3-4c54-a5f6-8f7697783c4c"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4090183e-6cb3-4d6e-ba2e-4c8eea617503"), 0, "123 Main St", "4020d113-9625-41ff-b600-8c7dfa677311", "testuser@example.com", true, false, null, "TESTUSER@EXAMPLE.COM", "TESTUSER", "AQAAAAIAAYagAAAAEB9IadiTs5rUKeqhkTfzotwXrRlsg99ZsKI87OwUVTVOeLO6u/Iyi10H+N6eupUR1Q==", "1234567890", true, "26286198-054e-4422-a6b0-ac7f02af75be", false, "testuser" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4090183e-6cb3-4d6e-ba2e-4c8eea617503"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("81232751-9ff3-4c54-a5f6-8f7697783c4c"), 0, "123 Main St", "669ba2ed-ff1a-4078-a0d4-aa5d7fae1c98", "testuser@example.com", true, false, null, "TESTUSER@EXAMPLE.COM", "TESTUSER", "AQAAAAIAAYagAAAAEDQ6vZiCpTWVaoHBXcuevlY7HiGxc5/LInRnseKsspMuq4WG2v6WCskG+4BoN0zbyQ==", "1234567890", true, "d6dee5a2-a104-4ce8-8c0b-ee31b4cda4ab", false, "testuser" });
        }
    }
}
