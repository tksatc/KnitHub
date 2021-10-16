using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KnitHub.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Designers",
                columns: table => new
                {
                    DesignerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 20, nullable: true),
                    LastName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designers", x => x.DesignerId);
                });

            migrationBuilder.CreateTable(
                name: "FiberTypess",
                columns: table => new
                {
                    FiberTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiberTypess", x => x.FiberTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FiberWeights",
                columns: table => new
                {
                    FiberWeightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiberWeights", x => x.FiberWeightId);
                });

            migrationBuilder.CreateTable(
                name: "ProductLines",
                columns: table => new
                {
                    ProductLineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLines", x => x.ProductLineId);
                });

            migrationBuilder.CreateTable(
                name: "SkillLevels",
                columns: table => new
                {
                    SkillLevelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillLevels", x => x.SkillLevelId);
                });

            migrationBuilder.CreateTable(
                name: "WearableSizes",
                columns: table => new
                {
                    WearableSizeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WearableSizes", x => x.WearableSizeId);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    ProductLineId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerId);
                    table.ForeignKey(
                        name: "FK_Manufacturers_ProductLines_ProductLineId",
                        column: x => x.ProductLineId,
                        principalTable: "ProductLines",
                        principalColumn: "ProductLineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patterns",
                columns: table => new
                {
                    PatternId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ManufacturerId = table.Column<int>(nullable: false),
                    DesignerId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    SkillLevelId = table.Column<int>(nullable: false),
                    StorageLocation = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patterns", x => x.PatternId);
                    table.ForeignKey(
                        name: "FK_Patterns_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patterns_Designers_DesignerId",
                        column: x => x.DesignerId,
                        principalTable: "Designers",
                        principalColumn: "DesignerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patterns_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patterns_SkillLevels_SkillLevelId",
                        column: x => x.SkillLevelId,
                        principalTable: "SkillLevels",
                        principalColumn: "SkillLevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yarn",
                columns: table => new
                {
                    YarnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    FiberTypeId = table.Column<int>(nullable: false),
                    FiberWeightId = table.Column<int>(nullable: false),
                    SkeinYardage = table.Column<int>(nullable: false),
                    SkeinWeight = table.Column<double>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yarn", x => x.YarnId);
                    table.ForeignKey(
                        name: "FK_Yarn_FiberTypess_FiberTypeId",
                        column: x => x.FiberTypeId,
                        principalTable: "FiberTypess",
                        principalColumn: "FiberTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yarn_FiberWeights_FiberWeightId",
                        column: x => x.FiberWeightId,
                        principalTable: "FiberWeights",
                        principalColumn: "FiberWeightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yarn_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatternDetails",
                columns: table => new
                {
                    PatternDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatternId = table.Column<int>(nullable: false),
                    yarnWeightKey = table.Column<string>(nullable: true),
                    yarnWeightValue = table.Column<string>(nullable: true),
                    needleTypeKey = table.Column<string>(nullable: true),
                    needleTypeValue = table.Column<string>(nullable: true),
                    needleSizeKey = table.Column<string>(nullable: true),
                    needleSizeValue = table.Column<string>(nullable: true),
                    wearableSizeKey = table.Column<string>(nullable: true),
                    wearableSizeValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatternDetails", x => x.PatternDetailId);
                    table.ForeignKey(
                        name: "FK_PatternDetails_Patterns_PatternId",
                        column: x => x.PatternId,
                        principalTable: "Patterns",
                        principalColumn: "PatternId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YarnDetails",
                columns: table => new
                {
                    YarnDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YarnId = table.Column<int>(nullable: false),
                    YarnColor = table.Column<string>(nullable: true),
                    YarnColorCode = table.Column<string>(nullable: true),
                    YarnColorLot = table.Column<string>(nullable: true),
                    QuantityOfSkeins = table.Column<double>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YarnDetails", x => x.YarnDetailId);
                    table.ForeignKey(
                        name: "FK_YarnDetails_Yarn_YarnId",
                        column: x => x.YarnId,
                        principalTable: "Yarn",
                        principalColumn: "YarnId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "home decor" },
                    { 2, "home use" },
                    { 3, "infant clothing" },
                    { 4, "children clothing" },
                    { 5, "women clothing" },
                    { 6, "men clothing" },
                    { 7, "wearable accessories" },
                    { 8, "toys" },
                    { 9, "pets" }
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "DesignerId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 3, "Trudy", "Van Stralen" },
                    { 2, null, "Churchmouse Classic" },
                    { 1, "Julie", "Weisenberger" }
                });

            migrationBuilder.InsertData(
                table: "FiberTypess",
                columns: new[] { "FiberTypeId", "Name" },
                values: new object[,]
                {
                    { 20, "Eyelash" },
                    { 18, "Mohair" },
                    { 17, "Polyester" },
                    { 16, "Railroad Ribbon" },
                    { 15, "Faux Fur" },
                    { 14, "Chenille" },
                    { 13, "Boucle" },
                    { 12, "Angora" },
                    { 11, "Acrylic" },
                    { 19, "Kid Mohair" },
                    { 9, "Hemp" },
                    { 8, "Silk" },
                    { 7, "Mercerized Cotton" },
                    { 6, "Cotton" },
                    { 5, "Organic Wool" },
                    { 4, "Merino Wool" },
                    { 3, "Alpaca" },
                    { 2, "Cashmere" },
                    { 1, "Wool" },
                    { 10, "Bamboo" }
                });

            migrationBuilder.InsertData(
                table: "FiberWeights",
                columns: new[] { "FiberWeightId", "Name", "Symbol" },
                values: new object[,]
                {
                    { 8, "Jumbo", 7 },
                    { 7, "Super Bulky", 6 },
                    { 6, "Bulky", 5 },
                    { 5, "Worsted", 4 },
                    { 1, "Lace", 0 },
                    { 3, "Fine", 2 },
                    { 2, "Fingering", 1 },
                    { 4, "DK", 3 }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ProductLineId", "Name" },
                values: new object[,]
                {
                    { 1, "yarn" },
                    { 2, "needles" },
                    { 3, "patterns" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "Name", "ProductLineId", "Url" },
                values: new object[,]
                {
                    { 7, "Louet", 3, "https://louet.com" },
                    { 6, "Churchmouse Yarns & Tees", 3, "https://churchmouseyarns.com" },
                    { 5, "Cocoknits", 3, "https://cocoknits.com" },
                    { 2, "Rowan", 1, "https://knitrowan.com" },
                    { 3, "Shibui", 1, "https://shibuiknits.com" },
                    { 1, "Nako", 1, "http://www.nako.com/" },
                    { 4, "Knitter's Pride", 2, "https://www.knitterspride.com" }
                });

            migrationBuilder.InsertData(
                table: "SkillLevels",
                columns: new[] { "SkillLevelId", "Level" },
                values: new object[,]
                {
                    { 4, "experienced" },
                    { 3, "intermediate" },
                    { 1, "beginner" },
                    { 2, "easy" }
                });

            migrationBuilder.InsertData(
                table: "WearableSizes",
                columns: new[] { "WearableSizeId", "Name" },
                values: new object[,]
                {
                    { 7, "2X" },
                    { 1, "XXS" },
                    { 2, "XS" },
                    { 3, "S" },
                    { 4, "M" },
                    { 5, "L" },
                    { 6, "XL" },
                    { 8, "3X" }
                });

            migrationBuilder.InsertData(
                table: "Patterns",
                columns: new[] { "PatternId", "CategoryId", "DateUpdated", "DesignerId", "ManufacturerId", "Name", "SkillLevelId", "StorageLocation" },
                values: new object[,]
                {
                    { 2, 5, new DateTime(2021, 10, 15, 14, 0, 39, 245, DateTimeKind.Local).AddTicks(1191), 2, 6, "Simple Tee", 3, "shelf" },
                    { 3, 5, new DateTime(2021, 10, 15, 14, 0, 39, 245, DateTimeKind.Local).AddTicks(1230), 1, 5, "Gretel", 3, "shelf" },
                    { 1, 5, new DateTime(2021, 10, 15, 14, 0, 39, 245, DateTimeKind.Local).AddTicks(46), 3, 7, "Rosemarie", 4, "shelf" }
                });

            migrationBuilder.InsertData(
                table: "Yarn",
                columns: new[] { "YarnId", "DateUpdated", "FiberTypeId", "FiberWeightId", "ManufacturerId", "Name", "SkeinWeight", "SkeinYardage" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 15, 14, 0, 39, 243, DateTimeKind.Local).AddTicks(6783), 3, 3, 1, "Arya Ebruli", 100.0, 550 },
                    { 2, new DateTime(2021, 10, 15, 14, 0, 39, 244, DateTimeKind.Local).AddTicks(4499), 4, 6, 2, "Brushed Fleece", 50.0, 115 },
                    { 3, new DateTime(2021, 10, 15, 14, 0, 39, 244, DateTimeKind.Local).AddTicks(4562), 19, 1, 3, "Silk Cloud", 25.0, 330 }
                });

            migrationBuilder.InsertData(
                table: "PatternDetails",
                columns: new[] { "PatternDetailId", "PatternId", "needleSizeKey", "needleSizeValue", "needleTypeKey", "needleTypeValue", "wearableSizeKey", "wearableSizeValue", "yarnWeightKey", "yarnWeightValue" },
                values: new object[] { 1, 3, "needleSizeId", "9", "needleTypeId", "5", "wearableSizeId", "5", "fiberWeightId", "3" });

            migrationBuilder.InsertData(
                table: "YarnDetails",
                columns: new[] { "YarnDetailId", "DateUpdated", "QuantityOfSkeins", "YarnColor", "YarnColorCode", "YarnColorLot", "YarnId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 15, 14, 0, 39, 244, DateTimeKind.Local).AddTicks(5164), 4.0, "Gray", "86398", "76643", 1 },
                    { 2, new DateTime(2021, 10, 15, 14, 0, 39, 244, DateTimeKind.Local).AddTicks(6228), 1.0, "Green", "00236", "3848", 2 },
                    { 3, new DateTime(2021, 10, 15, 14, 0, 39, 244, DateTimeKind.Local).AddTicks(6279), 7.0, "Silver", "2022", "1256", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_ProductLineId",
                table: "Manufacturers",
                column: "ProductLineId");

            migrationBuilder.CreateIndex(
                name: "IX_PatternDetails_PatternId",
                table: "PatternDetails",
                column: "PatternId");

            migrationBuilder.CreateIndex(
                name: "IX_Patterns_CategoryId",
                table: "Patterns",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Patterns_DesignerId",
                table: "Patterns",
                column: "DesignerId");

            migrationBuilder.CreateIndex(
                name: "IX_Patterns_ManufacturerId",
                table: "Patterns",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Patterns_SkillLevelId",
                table: "Patterns",
                column: "SkillLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Yarn_FiberTypeId",
                table: "Yarn",
                column: "FiberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Yarn_FiberWeightId",
                table: "Yarn",
                column: "FiberWeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Yarn_ManufacturerId",
                table: "Yarn",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_YarnDetails_YarnId",
                table: "YarnDetails",
                column: "YarnId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatternDetails");

            migrationBuilder.DropTable(
                name: "WearableSizes");

            migrationBuilder.DropTable(
                name: "YarnDetails");

            migrationBuilder.DropTable(
                name: "Patterns");

            migrationBuilder.DropTable(
                name: "Yarn");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Designers");

            migrationBuilder.DropTable(
                name: "SkillLevels");

            migrationBuilder.DropTable(
                name: "FiberTypess");

            migrationBuilder.DropTable(
                name: "FiberWeights");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "ProductLines");
        }
    }
}
