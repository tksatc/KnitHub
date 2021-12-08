﻿// <auto-generated />
using System;
using KnitHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KnitHub.Migrations
{
    [DbContext(typeof(KnitHubContext))]
    [Migration("20211206013137_unknown")]
    partial class unknown
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KnitHub.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "home decor"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "home use"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "infant clothing"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "children clothing"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "women clothing"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "men clothing"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "wearable accessories"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "toys"
                        },
                        new
                        {
                            CategoryId = 9,
                            Name = "pets"
                        });
                });

            modelBuilder.Entity("KnitHub.Models.Designer", b =>
                {
                    b.Property<int>("DesignerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("DesignerId");

                    b.ToTable("Designers");

                    b.HasData(
                        new
                        {
                            DesignerId = 1,
                            FirstName = "Julie",
                            LastName = "Weisenberger"
                        },
                        new
                        {
                            DesignerId = 2,
                            LastName = "Churchmouse Classic"
                        },
                        new
                        {
                            DesignerId = 3,
                            FirstName = "Trudy",
                            LastName = "Van Stralen"
                        });
                });

            modelBuilder.Entity("KnitHub.Models.FiberType", b =>
                {
                    b.Property<int>("FiberTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("FiberTypeId");

                    b.ToTable("FiberTypess");

                    b.HasData(
                        new
                        {
                            FiberTypeId = 1,
                            Name = "Wool"
                        },
                        new
                        {
                            FiberTypeId = 2,
                            Name = "Cashmere"
                        },
                        new
                        {
                            FiberTypeId = 3,
                            Name = "Alpaca"
                        },
                        new
                        {
                            FiberTypeId = 4,
                            Name = "Merino Wool"
                        },
                        new
                        {
                            FiberTypeId = 5,
                            Name = "Organic Wool"
                        },
                        new
                        {
                            FiberTypeId = 6,
                            Name = "Cotton"
                        },
                        new
                        {
                            FiberTypeId = 7,
                            Name = "Mercerized Cotton"
                        },
                        new
                        {
                            FiberTypeId = 8,
                            Name = "Silk"
                        },
                        new
                        {
                            FiberTypeId = 9,
                            Name = "Hemp"
                        },
                        new
                        {
                            FiberTypeId = 10,
                            Name = "Bamboo"
                        },
                        new
                        {
                            FiberTypeId = 11,
                            Name = "Acrylic"
                        },
                        new
                        {
                            FiberTypeId = 12,
                            Name = "Angora"
                        },
                        new
                        {
                            FiberTypeId = 13,
                            Name = "Boucle"
                        },
                        new
                        {
                            FiberTypeId = 14,
                            Name = "Chenille"
                        },
                        new
                        {
                            FiberTypeId = 15,
                            Name = "Faux Fur"
                        },
                        new
                        {
                            FiberTypeId = 16,
                            Name = "Railroad Ribbon"
                        },
                        new
                        {
                            FiberTypeId = 17,
                            Name = "Polyester"
                        },
                        new
                        {
                            FiberTypeId = 18,
                            Name = "Mohair"
                        },
                        new
                        {
                            FiberTypeId = 19,
                            Name = "Kid Mohair"
                        },
                        new
                        {
                            FiberTypeId = 20,
                            Name = "Eyelash"
                        });
                });

            modelBuilder.Entity("KnitHub.Models.FiberWeight", b =>
                {
                    b.Property<int>("FiberWeightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("Description")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("Symbol")
                        .HasColumnType("int");

                    b.HasKey("FiberWeightId");

                    b.ToTable("FiberWeights");

                    b.HasData(
                        new
                        {
                            FiberWeightId = 1,
                            Name = "Lace",
                            Symbol = 0
                        },
                        new
                        {
                            FiberWeightId = 2,
                            Name = "Fingering",
                            Symbol = 1
                        },
                        new
                        {
                            FiberWeightId = 3,
                            Name = "Fine",
                            Symbol = 2
                        },
                        new
                        {
                            FiberWeightId = 4,
                            Name = "DK",
                            Symbol = 3
                        },
                        new
                        {
                            FiberWeightId = 5,
                            Name = "Worsted",
                            Symbol = 4
                        },
                        new
                        {
                            FiberWeightId = 6,
                            Name = "Bulky",
                            Symbol = 5
                        },
                        new
                        {
                            FiberWeightId = 7,
                            Name = "Super Bulky",
                            Symbol = 6
                        },
                        new
                        {
                            FiberWeightId = 8,
                            Name = "Jumbo",
                            Symbol = 7
                        });
                });

            modelBuilder.Entity("KnitHub.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("ProductLineId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManufacturerId");

                    b.HasIndex("ProductLineId");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            ManufacturerId = 1,
                            Name = "Nako",
                            ProductLineId = 1,
                            Url = "http://www.nako.com/"
                        },
                        new
                        {
                            ManufacturerId = 2,
                            Name = "Rowan",
                            ProductLineId = 1,
                            Url = "https://knitrowan.com"
                        },
                        new
                        {
                            ManufacturerId = 3,
                            Name = "Shibui",
                            ProductLineId = 1,
                            Url = "https://shibuiknits.com"
                        },
                        new
                        {
                            ManufacturerId = 4,
                            Name = "Knitter's Pride",
                            ProductLineId = 2,
                            Url = "https://www.knitterspride.com"
                        },
                        new
                        {
                            ManufacturerId = 5,
                            Name = "Cocoknits",
                            ProductLineId = 3,
                            Url = "https://cocoknits.com"
                        },
                        new
                        {
                            ManufacturerId = 6,
                            Name = "Churchmouse Yarns & Tees",
                            ProductLineId = 3,
                            Url = "https://churchmouseyarns.com"
                        },
                        new
                        {
                            ManufacturerId = 7,
                            Name = "Louet",
                            ProductLineId = 1,
                            Url = "https://louet.com"
                        });
                });

            modelBuilder.Entity("KnitHub.Models.Pattern", b =>
                {
                    b.Property<int>("PatternId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("DesignerId")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("SkillLevelId")
                        .HasColumnType("int");

                    b.Property<string>("StorageLocation")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("PatternId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DesignerId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("SkillLevelId");

                    b.ToTable("Patterns");

                    b.HasData(
                        new
                        {
                            PatternId = 1,
                            CategoryId = 5,
                            DateUpdated = new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(7092),
                            DesignerId = 3,
                            ManufacturerId = 9,
                            Name = "Rosemarie",
                            SkillLevelId = 4,
                            StorageLocation = "shelf"
                        },
                        new
                        {
                            PatternId = 2,
                            CategoryId = 5,
                            DateUpdated = new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(8408),
                            DesignerId = 2,
                            ManufacturerId = 8,
                            Name = "Simple Tee",
                            SkillLevelId = 3,
                            StorageLocation = "shelf"
                        },
                        new
                        {
                            PatternId = 3,
                            CategoryId = 5,
                            DateUpdated = new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(8451),
                            DesignerId = 1,
                            ManufacturerId = 7,
                            Name = "Gretel",
                            SkillLevelId = 3,
                            StorageLocation = "shelf"
                        });
                });

            modelBuilder.Entity("KnitHub.Models.PatternDetail", b =>
                {
                    b.Property<int>("PatternDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PatternId")
                        .HasColumnType("int");

                    b.Property<string>("needleSizeKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("needleSizeValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("needleTypeKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("needleTypeValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wearableSizeKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wearableSizeValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yarnWeightKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yarnWeightValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatternDetailId");

                    b.HasIndex("PatternId");

                    b.ToTable("PatternDetails");

                    b.HasData(
                        new
                        {
                            PatternDetailId = 1,
                            PatternId = 3,
                            needleSizeKey = "needleSizeId",
                            needleSizeValue = "9",
                            needleTypeKey = "needleTypeId",
                            needleTypeValue = "5",
                            wearableSizeKey = "wearableSizeId",
                            wearableSizeValue = "5",
                            yarnWeightKey = "fiberWeightId",
                            yarnWeightValue = "3"
                        });
                });

            modelBuilder.Entity("KnitHub.Models.ProductLine", b =>
                {
                    b.Property<int>("ProductLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ProductLineId");

                    b.ToTable("ProductLines");

                    b.HasData(
                        new
                        {
                            ProductLineId = 1,
                            Name = "yarn"
                        },
                        new
                        {
                            ProductLineId = 2,
                            Name = "needles"
                        },
                        new
                        {
                            ProductLineId = 3,
                            Name = "patterns"
                        });
                });

            modelBuilder.Entity("KnitHub.Models.SkillLevel", b =>
                {
                    b.Property<int>("SkillLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("SkillLevelId");

                    b.ToTable("SkillLevels");

                    b.HasData(
                        new
                        {
                            SkillLevelId = 1,
                            Level = "beginner"
                        },
                        new
                        {
                            SkillLevelId = 2,
                            Level = "easy"
                        },
                        new
                        {
                            SkillLevelId = 3,
                            Level = "intermediate"
                        },
                        new
                        {
                            SkillLevelId = 4,
                            Level = "experienced"
                        });
                });

            modelBuilder.Entity("KnitHub.Models.WearableSize", b =>
                {
                    b.Property<int>("WearableSizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("WearableSizeId");

                    b.ToTable("WearableSizes");

                    b.HasData(
                        new
                        {
                            WearableSizeId = 1,
                            Name = "XXS"
                        },
                        new
                        {
                            WearableSizeId = 2,
                            Name = "XS"
                        },
                        new
                        {
                            WearableSizeId = 3,
                            Name = "S"
                        },
                        new
                        {
                            WearableSizeId = 4,
                            Name = "M"
                        },
                        new
                        {
                            WearableSizeId = 5,
                            Name = "L"
                        },
                        new
                        {
                            WearableSizeId = 6,
                            Name = "XL"
                        },
                        new
                        {
                            WearableSizeId = 7,
                            Name = "2X"
                        },
                        new
                        {
                            WearableSizeId = 8,
                            Name = "3X"
                        });
                });

            modelBuilder.Entity("KnitHub.Models.Yarn", b =>
                {
                    b.Property<int>("YarnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("FiberTypeId")
                        .HasColumnType("int");

                    b.Property<int>("FiberWeightId")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<double>("SkeinWeight")
                        .HasColumnType("float");

                    b.Property<int>("SkeinYardage")
                        .HasColumnType("int");

                    b.HasKey("YarnId");

                    b.HasIndex("FiberTypeId");

                    b.HasIndex("FiberWeightId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Yarn");

                    b.HasData(
                        new
                        {
                            YarnId = 1,
                            DateUpdated = new DateTime(2021, 12, 5, 17, 31, 37, 97, DateTimeKind.Local).AddTicks(2260),
                            FiberTypeId = 3,
                            FiberWeightId = 3,
                            ManufacturerId = 1,
                            Name = "Arya Ebruli",
                            SkeinWeight = 100.0,
                            SkeinYardage = 550
                        },
                        new
                        {
                            YarnId = 2,
                            DateUpdated = new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(1325),
                            FiberTypeId = 4,
                            FiberWeightId = 6,
                            ManufacturerId = 2,
                            Name = "Brushed Fleece",
                            SkeinWeight = 50.0,
                            SkeinYardage = 115
                        },
                        new
                        {
                            YarnId = 3,
                            DateUpdated = new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(1398),
                            FiberTypeId = 19,
                            FiberWeightId = 1,
                            ManufacturerId = 3,
                            Name = "Silk Cloud",
                            SkeinWeight = 25.0,
                            SkeinYardage = 330
                        });
                });

            modelBuilder.Entity("KnitHub.Models.YarnDetail", b =>
                {
                    b.Property<int>("YarnDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<double>("QuantityOfSkeins")
                        .HasColumnType("float");

                    b.Property<string>("YarnColor")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("YarnColorCode")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("YarnColorLot")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("YarnId")
                        .HasColumnType("int");

                    b.HasKey("YarnDetailId");

                    b.HasIndex("YarnId");

                    b.ToTable("YarnDetails");

                    b.HasData(
                        new
                        {
                            YarnDetailId = 1,
                            DateUpdated = new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(2092),
                            QuantityOfSkeins = 4.0,
                            YarnColor = "Gray",
                            YarnColorCode = "86398",
                            YarnColorLot = "76643",
                            YarnId = 1
                        },
                        new
                        {
                            YarnDetailId = 2,
                            DateUpdated = new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(3250),
                            QuantityOfSkeins = 1.0,
                            YarnColor = "Green",
                            YarnColorCode = "00236",
                            YarnColorLot = "3848",
                            YarnId = 2
                        },
                        new
                        {
                            YarnDetailId = 3,
                            DateUpdated = new DateTime(2021, 12, 5, 17, 31, 37, 98, DateTimeKind.Local).AddTicks(3289),
                            QuantityOfSkeins = 7.0,
                            YarnColor = "Silver",
                            YarnColorCode = "2022",
                            YarnColorLot = "1256",
                            YarnId = 3
                        });
                });

            modelBuilder.Entity("KnitHub.Models.Manufacturer", b =>
                {
                    b.HasOne("KnitHub.Models.ProductLine", "ProductLine")
                        .WithMany("Manufacturers")
                        .HasForeignKey("ProductLineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KnitHub.Models.Pattern", b =>
                {
                    b.HasOne("KnitHub.Models.Category", "Category")
                        .WithMany("Patterns")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KnitHub.Models.Designer", "Designer")
                        .WithMany("Patterns")
                        .HasForeignKey("DesignerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KnitHub.Models.Manufacturer", "Manufacturer")
                        .WithMany("Patterns")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KnitHub.Models.SkillLevel", "SkillLevel")
                        .WithMany("Patterns")
                        .HasForeignKey("SkillLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KnitHub.Models.PatternDetail", b =>
                {
                    b.HasOne("KnitHub.Models.Pattern", "Pattern")
                        .WithMany("PatternDetails")
                        .HasForeignKey("PatternId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KnitHub.Models.Yarn", b =>
                {
                    b.HasOne("KnitHub.Models.FiberType", "FiberType")
                        .WithMany("Yarns")
                        .HasForeignKey("FiberTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KnitHub.Models.FiberWeight", "FiberWeight")
                        .WithMany("Yarns")
                        .HasForeignKey("FiberWeightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KnitHub.Models.Manufacturer", "Manufacturer")
                        .WithMany("Yarns")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KnitHub.Models.YarnDetail", b =>
                {
                    b.HasOne("KnitHub.Models.Yarn", "Yarn")
                        .WithMany("YarnDetails")
                        .HasForeignKey("YarnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
