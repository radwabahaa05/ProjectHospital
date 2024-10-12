using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepiProject.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 3, 1, 12, 49, 785, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 4, 1, 12, 49, 785, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 2, 1, 12, 49, 785, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 17, 1, 12, 49, 785, DateTimeKind.Local).AddTicks(2800));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 3, 1, 5, 49, 380, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 4, 1, 5, 49, 380, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 2, 1, 5, 49, 380, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 17, 1, 5, 49, 380, DateTimeKind.Local).AddTicks(6299));
        }
    }
}
