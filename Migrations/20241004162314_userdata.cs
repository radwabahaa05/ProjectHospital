using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepiProject.Migrations
{
    public partial class userdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 5, 19, 23, 14, 287, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 6, 19, 23, 14, 287, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 4, 19, 23, 14, 287, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 19, 19, 23, 14, 287, DateTimeKind.Local).AddTicks(3224));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 5, 18, 33, 7, 659, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 6, 18, 33, 7, 659, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 4, 18, 33, 7, 659, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 19, 18, 33, 7, 659, DateTimeKind.Local).AddTicks(4129));
        }
    }
}
