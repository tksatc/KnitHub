using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KnitHub.Migrations
{
    public partial class commentOutMFSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Name",
                value: "childrens clothing");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "Name",
                value: "womens clothing");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "Name",
                value: "mens clothing");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 6,
                column: "Name",
                value: "Churchmouse Yarns & Teas");

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 12, 8, 56, 17, 485, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 12, 8, 56, 17, 485, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 12, 8, 56, 17, 485, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.InsertData(
                table: "WearableSizes",
                columns: new[] { "WearableSizeId", "Name" },
                values: new object[] { 9, "none" });

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 12, 8, 56, 17, 483, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 12, 8, 56, 17, 484, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 12, 8, 56, 17, 484, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 12, 8, 56, 17, 484, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 12, 8, 56, 17, 484, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 12, 8, 56, 17, 484, DateTimeKind.Local).AddTicks(7960));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WearableSizes",
                keyColumn: "WearableSizeId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Name",
                value: "children clothing");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "Name",
                value: "women clothing");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "Name",
                value: "men clothing");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 6,
                column: "Name",
                value: "Churchmouse Yarns & Tees");

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "Name", "ProductLineId", "Url" },
                values: new object[] { 4, "Knitter's Pride", 2, "https://www.knitterspride.com" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 10, 17, 7, 46, 599, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 10, 17, 7, 46, 599, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 10, 17, 7, 46, 599, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 10, 17, 7, 46, 598, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 10, 17, 7, 46, 599, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 10, 17, 7, 46, 599, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 10, 17, 7, 46, 599, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 10, 17, 7, 46, 599, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 12, 10, 17, 7, 46, 599, DateTimeKind.Local).AddTicks(2847));
        }
    }
}
