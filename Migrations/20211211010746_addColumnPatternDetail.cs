using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KnitHub.Migrations
{
    public partial class addColumnPatternDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "patternYardageKey",
                table: "PatternDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "patternYardageValue",
                table: "PatternDetails",
                maxLength: 5,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PatternDetails",
                keyColumn: "PatternDetailId",
                keyValue: 1,
                columns: new[] { "needleSizeValue", "needleTypeValue", "patternYardageKey", "patternYardageValue", "yarnWeightValue" },
                values: new object[] { "6", "circular 29", "patternYardageId", "750", "2" });

            migrationBuilder.InsertData(
                table: "PatternDetails",
                columns: new[] { "PatternDetailId", "PatternId", "needleSizeKey", "needleSizeValue", "needleTypeKey", "needleTypeValue", "patternYardageKey", "patternYardageValue", "wearableSizeKey", "wearableSizeValue", "yarnWeightKey", "yarnWeightValue" },
                values: new object[,]
                {
                    { 2, 1, "needleSizeId", "2", "needleTypeId", "circular 32", "patternYardageId", "1750", "wearableSizeId", "5", "fiberWeightId", "0" },
                    { 3, 2, "needleSizeId", "4", "needleTypeId", "any", "patternYardageId", "1295", "wearableSizeId", "5", "fiberWeightId", "3" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PatternDetails",
                keyColumn: "PatternDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PatternDetails",
                keyColumn: "PatternDetailId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "patternYardageKey",
                table: "PatternDetails");

            migrationBuilder.DropColumn(
                name: "patternYardageValue",
                table: "PatternDetails");

            migrationBuilder.UpdateData(
                table: "PatternDetails",
                keyColumn: "PatternDetailId",
                keyValue: 1,
                columns: new[] { "needleSizeValue", "needleTypeValue", "yarnWeightValue" },
                values: new object[] { "9", "5", "3" });

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
