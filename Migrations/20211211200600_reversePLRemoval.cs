using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KnitHub.Migrations
{
    public partial class reversePLRemoval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 6, 0, 128, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 6, 0, 128, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 6, 0, 128, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ProductLineId", "Name" },
                values: new object[] { 3, "patterns" });

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 6, 0, 127, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 6, 0, 128, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 6, 0, 128, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 6, 0, 128, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 6, 0, 128, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 6, 0, 128, DateTimeKind.Local).AddTicks(4366));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "ProductLineId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "Name", "ProductLineId", "Url" },
                values: new object[,]
                {
                    { 6, "Churchmouse Yarns & Tees", 3, "https://churchmouseyarns.com" },
                    { 5, "Cocoknits", 3, "https://cocoknits.com" }
                });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 3, 43, 282, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 3, 43, 282, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 3, 43, 282, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 3, 43, 280, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 3, 43, 281, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 3, 43, 281, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 3, 43, 281, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 3, 43, 281, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 11, 12, 3, 43, 281, DateTimeKind.Local).AddTicks(8707));
        }
    }
}
