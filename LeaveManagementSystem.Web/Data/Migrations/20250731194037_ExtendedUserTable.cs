using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c2d3e4-f5a6-7b8c-9d0e-f1a2b3c4d5e6",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "stamp-admin-user", new DateOnly(1985, 12, 1), "Default", "Admin", "SECURITYSTAMP" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c2d3e4-f5a6-7b8c-9d0e-f1a2b3c4d5e6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3d19f0d-fc0e-4a21-95b7-ea80b5681a20", "d38301d1-e468-4e6d-936f-b61b8c5f5fc8" });
        }
    }
}
