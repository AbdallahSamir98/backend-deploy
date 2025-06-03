using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraduationProjecrStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Data_Seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cdb5a13c-0377-481e-8363-6f8752914c70"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "College",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "College",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Computer Science" },
                    { 2, "Science" },
                    { 3, "Engineering" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Manager", "Name" },
                values: new object[,]
                {
                    { 1, "Nabil Mustafa", "IS" },
                    { 2, "Ehab Rushdy", "IT" },
                    { 3, "Mohamed ElMahdy", "CS" },
                    { 4, "Ahmed ElSayed", "DS" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("883d4839-63e5-48c9-817a-361957533f2b"), 0, "123 Main St", "c7de6551-09be-42f3-bf83-3dc2adb87507", "testuser@example.com", true, false, null, "TESTUSER@EXAMPLE.COM", "TESTUSER", "AQAAAAIAAYagAAAAEGAhalghxp5XDOOZIkky90R41Tsl0EhzfJARDz/56TWed+wlE9285sOzeleI/asbDQ==", "1234567890", true, "9ab0dced-bdb2-496b-95f3-279aec802cb0", false, "testuser" });

            migrationBuilder.InsertData(
                table: "Supervisor",
                columns: new[] { "Id", "Address", "BirthDate", "DepartmentId", "FirstName", "LastName", "Name", "Position" },
                values: new object[,]
                {
                    { 1, "Cairo University, Building A", new DateTime(1975, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ahmed", "Youssef", null, "Professor" },
                    { 2, "Ain Shams University, Building B", new DateTime(1980, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Fatima", "Ali", null, "Associate Professor" },
                    { 3, "Alexandria University, Building C", new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mohamed", "Hassan", null, "Assistant Lecturer" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "CollegeId", "ContentType", "Data", "DepartmentId", "Description", "Name", "SupervisorId", "UploadAt" },
                values: new object[,]
                {
                    { 1, 1, null, null, 1, null, null, 1, new DateTime(2025, 4, 24, 4, 40, 30, 280, DateTimeKind.Local).AddTicks(6185) },
                    { 2, 2, null, null, 2, null, null, 2, new DateTime(2025, 5, 4, 4, 40, 30, 280, DateTimeKind.Local).AddTicks(6315) },
                    { 3, 3, null, null, 3, null, null, 3, new DateTime(2025, 5, 14, 4, 40, 30, 280, DateTimeKind.Local).AddTicks(6332) }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Address", "BirthDate", "DepartmentId", "FirstName", "GPA", "LastName", "Level", "Name", "ProjectId", "SupervisorId" },
                values: new object[,]
                {
                    { 1, "Nasr City, Cairo", new DateTime(2002, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Omar", 3.7000000000000002, "Mahmoud", 4, null, 1, 1 },
                    { 2, "Maadi, Cairo", new DateTime(2001, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Salma", 3.8999999999999999, "Hussein", 4, null, 2, 2 },
                    { 3, "Giza, El Haram", new DateTime(2003, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Youssef", 3.3999999999999999, "Tariq", 3, null, 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("883d4839-63e5-48c9-817a-361957533f2b"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "College",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "College",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "College",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Supervisor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supervisor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Supervisor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "College",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("cdb5a13c-0377-481e-8363-6f8752914c70"), 0, "123 Main St", "be0a0bf1-5711-4b4c-acee-35c3de7119e4", "testuser@example.com", true, false, null, "TESTUSER@EXAMPLE.COM", "TESTUSER", "AQAAAAIAAYagAAAAEEaKcyIHO3g96MdeytFTjea3UDvFvks41PpdwBAIw+TvdNsaxXGVY3chse9SozS4tQ==", "1234567890", true, "b0191520-3bf5-44f4-a499-ef96f226bc80", false, "testuser" });
        }
    }
}
