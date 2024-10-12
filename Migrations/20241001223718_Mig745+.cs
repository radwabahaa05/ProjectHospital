using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepiProject.Migrations
{
    public partial class Mig745 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 3, 1, 37, 17, 734, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 4, 1, 37, 17, 734, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 2, 1, 37, 17, 734, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 17, 1, 37, 17, 734, DateTimeKind.Local).AddTicks(2941));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
