using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KnitHub.Models
{
    public class KnitHubContext : DbContext
    {
        public KnitHubContext(DbContextOptions<KnitHubContext> options)
            : base(options)
        { }

        public DbSet<ProductLine> ProductLines { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<FiberType> FiberTypess { get; set; }
        public DbSet<FiberWeight> FiberWeights { get; set; }
        public DbSet<Yarn> Yarn { get; set; }
        public DbSet<YarnDetail> YarnDetails { get; set; }
        public DbSet<Designer> Designers { get; set; }
        public DbSet<SkillLevel> SkillLevels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<WearableSize> WearableSizes { get; set; }
        public DbSet<Pattern> Patterns { get; set; }
        public DbSet<PatternDetail> PatternDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductLine>().HasData(
                new ProductLine { ProductLineId = 1, Name = "yarn" },
                new ProductLine { ProductLineId = 2, Name = "needles" },
                new ProductLine { ProductLineId = 3, Name = "patterns" }
                );
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer { ManufacturerId = 1, Name = "Nako", ProductLineId = 1, Url = "http://www.nako.com/" },
                new Manufacturer { ManufacturerId = 2, Name = "Rowan", ProductLineId = 1, Url = "https://knitrowan.com" },
                new Manufacturer { ManufacturerId = 3, Name = "Shibui", ProductLineId = 1, Url = "https://shibuiknits.com" },
                //new Manufacturer { ManufacturerId = 4, Name = "Knitter's Pride", ProductLineId= 2, Url = "https://www.knitterspride.com" },
                new Manufacturer { ManufacturerId = 5, Name = "Cocoknits", ProductLineId = 3, Url = "https://cocoknits.com" },
                new Manufacturer { ManufacturerId = 6, Name = "Churchmouse Yarns & Teas", ProductLineId = 3, Url = "https://churchmouseyarns.com" },
                new Manufacturer { ManufacturerId = 7, Name = "Louet", ProductLineId = 1, Url = "https://louet.com" }
                );
            modelBuilder.Entity<FiberType>().HasData(
                new FiberType { FiberTypeId = 1, Name = "Wool" },
                new FiberType { FiberTypeId = 2, Name = "Cashmere" },
                new FiberType { FiberTypeId = 3, Name = "Alpaca" },
                new FiberType { FiberTypeId = 4, Name = "Merino Wool" },
                new FiberType { FiberTypeId = 5, Name = "Organic Wool" },
                new FiberType { FiberTypeId = 6, Name = "Cotton" },
                new FiberType { FiberTypeId = 7, Name = "Mercerized Cotton" },
                new FiberType { FiberTypeId = 8, Name = "Silk" },
                new FiberType { FiberTypeId = 9, Name = "Hemp" },
                new FiberType { FiberTypeId = 10, Name = "Bamboo" },
                new FiberType { FiberTypeId = 11, Name = "Acrylic" },
                new FiberType { FiberTypeId = 12, Name = "Angora" },
                new FiberType { FiberTypeId = 13, Name = "Boucle" },
                new FiberType { FiberTypeId = 14, Name = "Chenille" },
                new FiberType { FiberTypeId = 15, Name = "Faux Fur" },
                new FiberType { FiberTypeId = 16, Name = "Railroad Ribbon" },
                new FiberType { FiberTypeId = 17, Name = "Polyester" },
                new FiberType { FiberTypeId = 18, Name = "Mohair" },
                new FiberType { FiberTypeId = 19, Name = "Kid Mohair" },
                new FiberType { FiberTypeId = 20, Name = "Eyelash" }
                );
            modelBuilder.Entity<FiberWeight>().HasData(
                new FiberWeight { FiberWeightId = 1, Name = "Lace", Symbol = 0 },
                new FiberWeight { FiberWeightId = 2, Name = "Fingering", Symbol = 1 },
                new FiberWeight { FiberWeightId = 3, Name = "Fine", Symbol = 2 },
                new FiberWeight { FiberWeightId = 4, Name = "DK", Symbol = 3 },
                new FiberWeight { FiberWeightId = 5, Name = "Worsted", Symbol = 4 },
                new FiberWeight { FiberWeightId = 6, Name = "Bulky", Symbol = 5 },
                new FiberWeight { FiberWeightId = 7, Name = "Super Bulky", Symbol = 6 },
                new FiberWeight { FiberWeightId = 8, Name = "Jumbo", Symbol = 7 }
                );
            modelBuilder.Entity<Yarn>().HasData(
                new Yarn { YarnId = 1, Name = "Arya Ebruli", ManufacturerId = 1, FiberTypeId = 3, FiberWeightId = 3, SkeinYardage = 550, SkeinWeight = 100 },
                new Yarn { YarnId = 2, Name = "Brushed Fleece", ManufacturerId = 2, FiberTypeId = 4, FiberWeightId = 6, SkeinYardage = 115, SkeinWeight = 50 },
                new Yarn { YarnId = 3, Name = "Silk Cloud", ManufacturerId = 3, FiberTypeId = 19, FiberWeightId = 1, SkeinYardage = 330, SkeinWeight = 25 }
                );
            modelBuilder.Entity<YarnDetail>().HasData(
                new YarnDetail { YarnDetailId = 1, YarnId = 1, YarnColor = "Gray", YarnColorCode = "86398", YarnColorLot = "76643", QuantityOfSkeins = 4 },
                new YarnDetail { YarnDetailId = 2, YarnId = 2, YarnColor = "Green", YarnColorCode = "00236", YarnColorLot = "3848", QuantityOfSkeins = 1 },
                new YarnDetail { YarnDetailId = 3, YarnId = 3, YarnColor = "Silver", YarnColorCode = "2022", YarnColorLot = "1256", QuantityOfSkeins = 7 }
                );
            modelBuilder.Entity<Designer>().HasData(
                new Designer { DesignerId = 1, FirstName = "Julie", LastName = "Weisenberger" },
                new Designer { DesignerId = 2, LastName = "Churchmouse Classic" },
                new Designer { DesignerId = 3, FirstName = "Trudy", LastName = "Van Stralen" }
                );
            modelBuilder.Entity<SkillLevel>().HasData(
                new SkillLevel { SkillLevelId = 1, Level = "beginner" },
                new SkillLevel { SkillLevelId = 2, Level = "easy" },
                new SkillLevel { SkillLevelId = 3, Level = "intermediate" },
                new SkillLevel { SkillLevelId = 4, Level = "experienced" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "home decor" },
                new Category { CategoryId = 2, Name = "home use" },
                new Category { CategoryId = 3, Name = "infant clothing" },
                new Category { CategoryId = 4, Name = "childrens clothing" },
                new Category { CategoryId = 5, Name = "womens clothing" },
                new Category { CategoryId = 6, Name = "mens clothing" },
                new Category { CategoryId = 7, Name = "wearable accessories" },
                new Category { CategoryId = 8, Name = "toys" },
                new Category { CategoryId = 9, Name = "pets" }
                );
            modelBuilder.Entity<WearableSize>().HasData(
                new WearableSize { WearableSizeId = 1, Name = "XXS" },
                new WearableSize { WearableSizeId = 2, Name = "XS" },
                new WearableSize { WearableSizeId = 3, Name = "S" },
                new WearableSize { WearableSizeId = 4, Name = "M" },
                new WearableSize { WearableSizeId = 5, Name = "L" },
                new WearableSize { WearableSizeId = 6, Name = "XL" },
                new WearableSize { WearableSizeId = 7, Name = "2X" },
                new WearableSize { WearableSizeId = 8, Name = "3X" },
                new WearableSize { WearableSizeId = 9, Name = "none"}
                );
            modelBuilder.Entity<Pattern>().HasData(
                new Pattern
                {
                    PatternId = 1,
                    Name = "Rosemarie",
                    ManufacturerId = 9,
                    DesignerId = 3,
                    CategoryId = 5,
                    SkillLevelId = 4,
                    StorageLocation = "shelf"
                },
                new Pattern
                {
                    PatternId = 2,
                    Name = "Simple Tee",
                    ManufacturerId = 8,
                    DesignerId = 2,
                    CategoryId = 5,
                    SkillLevelId = 3,
                    StorageLocation = "shelf"
                },
                new Pattern
                {
                    PatternId = 3,
                    Name = "Gretel",
                    ManufacturerId = 7,
                    DesignerId = 1,
                    CategoryId = 5,
                    SkillLevelId = 3,
                    StorageLocation = "shelf"
                }
                );
            modelBuilder.Entity<PatternDetail>().HasData(
                new PatternDetail
                {
                    PatternDetailId = 1,
                    PatternId = 3,
                    yarnWeightKey = "fiberWeightId",
                    yarnWeightValue = "2",
                    needleTypeKey = "needleTypeId",
                    needleTypeValue = "circular 29",
                    needleSizeKey = "needleSizeId",
                    needleSizeValue = "6",
                    wearableSizeKey = "wearableSizeId",
                    wearableSizeValue = "5",
                    patternYardageKey = "patternYardageId",
                    patternYardageValue = "750"
                },
                new PatternDetail
                {
                    PatternDetailId = 2,
                    PatternId = 1,
                    yarnWeightKey = "fiberWeightId",
                    yarnWeightValue = "0",
                    needleTypeKey = "needleTypeId",
                    needleTypeValue = "circular 32",
                    needleSizeKey = "needleSizeId",
                    needleSizeValue = "2",
                    wearableSizeKey = "wearableSizeId",
                    wearableSizeValue = "5",
                    patternYardageKey = "patternYardageId",
                    patternYardageValue = "1750"
                },
                new PatternDetail
                {
                    PatternDetailId = 3,
                    PatternId = 2,
                    yarnWeightKey = "fiberWeightId",
                    yarnWeightValue = "3",
                    needleTypeKey = "needleTypeId",
                    needleTypeValue = "any",
                    needleSizeKey = "needleSizeId",
                    needleSizeValue = "4",
                    wearableSizeKey = "wearableSizeId",
                    wearableSizeValue = "5",
                    patternYardageKey = "patternYardageId",
                    patternYardageValue = "1295"
                }
                );
        }
    }
}
