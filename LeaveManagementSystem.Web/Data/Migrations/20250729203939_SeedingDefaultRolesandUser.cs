using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3737dfa2-25d4-4208-a282-1d36bcedb791", null, "Administrator", "ADMINISTRATOR" },
                    { "3ab33054-b56c-46c8-bebc-1776fbd72957", null, "Employee", "EMPLOYEE" },
                    { "6253acfb-87fe-41e2-b652-1253cfc89bc2", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b1c2d3e4-f5a6-7b8c-9d0e-f1a2b3c4d5e6", 0, "f3d19f0d-fc0e-4a21-95b7-ea80b5681a20", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEAi0MtD61WkEvg23ppdEEA67aAdJf4JbziuTytj1I0ISzqg3I2r0rUYyc6wITmwJIg==", null, false, "d38301d1-e468-4e6d-936f-b61b8c5f5fc8", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3737dfa2-25d4-4208-a282-1d36bcedb791", "b1c2d3e4-f5a6-7b8c-9d0e-f1a2b3c4d5e6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ab33054-b56c-46c8-bebc-1776fbd72957");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6253acfb-87fe-41e2-b652-1253cfc89bc2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3737dfa2-25d4-4208-a282-1d36bcedb791", "b1c2d3e4-f5a6-7b8c-9d0e-f1a2b3c4d5e6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3737dfa2-25d4-4208-a282-1d36bcedb791");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c2d3e4-f5a6-7b8c-9d0e-f1a2b3c4d5e6");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }
    }
}
