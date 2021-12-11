using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KnitHub.Migrations
{
    public partial class changingProductLineForeignKeyAnnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 35, 5, 918, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 35, 5, 918, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 35, 5, 918, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 35, 5, 917, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 35, 5, 918, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 35, 5, 918, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 35, 5, 918, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 35, 5, 918, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 35, 5, 918, DateTimeKind.Local).AddTicks(1853));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 28, 49, 753, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 28, 49, 753, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 28, 49, 753, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 28, 49, 752, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 28, 49, 753, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 28, 49, 753, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 28, 49, 753, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 28, 49, 753, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 28, 49, 753, DateTimeKind.Local).AddTicks(4299));
        }
    }
}
