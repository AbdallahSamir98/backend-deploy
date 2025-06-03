using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProjecrStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Nullable_projectFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4090183e-6cb3-4d6e-ba2e-4c8eea617503"));

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Project",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Data",
                table: "Project",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContentType",
                table: "Project",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("cdb5a13c-0377-481e-8363-6f8752914c70"), 0, "123 Main St", "be0a0bf1-5711-4b4c-acee-35c3de7119e4", "testuser@example.com", true, false, null, "TESTUSER@EXAMPLE.COM", "TESTUSER", "AQAAAAIAAYagAAAAEEaKcyIHO3g96MdeytFTjea3UDvFvks41PpdwBAIw+TvdNsaxXGVY3chse9SozS4tQ==", "1234567890", true, "b0191520-3bf5-44f4-a499-ef96f226bc80", false, "testuser" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cdb5a13c-0377-481e-8363-6f8752914c70"));

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Data",
                table: "Project",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContentType",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4090183e-6cb3-4d6e-ba2e-4c8eea617503"), 0, "123 Main St", "4020d113-9625-41ff-b600-8c7dfa677311", "testuser@example.com", true, false, null, "TESTUSER@EXAMPLE.COM", "TESTUSER", "AQAAAAIAAYagAAAAEB9IadiTs5rUKeqhkTfzotwXrRlsg99ZsKI87OwUVTVOeLO6u/Iyi10H+N6eupUR1Q==", "1234567890", true, "26286198-054e-4422-a6b0-ac7f02af75be", false, "testuser" });
        }
    }
}
