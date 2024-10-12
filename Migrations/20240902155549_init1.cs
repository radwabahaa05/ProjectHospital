using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepiProject.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 3, 18, 55, 47, 453, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 4, 18, 55, 47, 453, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 8, 3, 18, 55, 47, 453, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 8, 18, 18, 55, 47, 453, DateTimeKind.Local).AddTicks(4734));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 3, 2, 35, 12, 987, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 4, 2, 35, 12, 987, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 8, 3, 2, 35, 12, 987, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 8, 18, 2, 35, 12, 987, DateTimeKind.Local).AddTicks(8873));
        }
    }
}
