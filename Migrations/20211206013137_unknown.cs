using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KnitHub.Migrations
{
    public partial class unknown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 5, 17, 31, 37, 97, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(3289));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 28, 9, 6, 13, 94, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 28, 9, 6, 13, 95, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 28, 9, 6, 13, 95, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 28, 9, 6, 13, 93, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 28, 9, 6, 13, 94, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 28, 9, 6, 13, 94, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 28, 9, 6, 13, 94, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 28, 9, 6, 13, 94, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 28, 9, 6, 13, 94, DateTimeKind.Local).AddTicks(5439));
        }
    }
}
