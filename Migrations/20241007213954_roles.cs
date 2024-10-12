using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepiProject.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 9, 0, 39, 53, 398, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 10, 0, 39, 53, 398, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 8, 0, 39, 53, 398, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 23, 0, 39, 53, 398, DateTimeKind.Local).AddTicks(4103));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 9, 0, 8, 32, 527, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 10, 0, 8, 32, 527, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 8, 0, 8, 32, 527, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 23, 0, 8, 32, 527, DateTimeKind.Local).AddTicks(345));
        }
    }
}
