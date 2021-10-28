using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KnitHub.Migrations
{
    public partial class AddedAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FiberWeights",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "YarnColorLot",
                table: "YarnDetails",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "YarnColorCode",
                table: "YarnDetails",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "YarnColor",
                table: "YarnDetails",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Level",
                table: "SkillLevels",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StorageLocation",
                table: "Patterns",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FiberWeights",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FiberTypess",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 1,
                column: "ProductLineId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 2,
                column: "ProductLineId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 3,
                column: "ProductLineId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 4,
                column: "ProductLineId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 5,
                column: "ProductLineId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 6,
                column: "ProductLineId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 7,
                column: "ProductLineId",
                value: 1);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "FiberWeights",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "YarnColorLot",
                table: "YarnDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "YarnColorCode",
                table: "YarnDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "YarnColor",
                table: "YarnDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Level",
                table: "SkillLevels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "StorageLocation",
                table: "Patterns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FiberWeights",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FiberTypess",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 1,
                column: "ProductLineId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 2,
                column: "ProductLineId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 3,
                column: "ProductLineId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 4,
                column: "ProductLineId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 5,
                column: "ProductLineId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 6,
                column: "ProductLineId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 7,
                column: "ProductLineId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 15, 14, 0, 39, 245, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 15, 14, 0, 39, 245, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "PatternId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 15, 14, 0, 39, 245, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 15, 14, 0, 39, 243, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 15, 14, 0, 39, 244, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "YarnId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 15, 14, 0, 39, 244, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 15, 14, 0, 39, 244, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 15, 14, 0, 39, 244, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "YarnDetails",
                keyColumn: "YarnDetailId",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2021, 10, 15, 14, 0, 39, 244, DateTimeKind.Local).AddTicks(6279));
        }
    }
}
