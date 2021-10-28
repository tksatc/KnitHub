using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class PatternDetail
    {
        [Key]
        public int PatternDetailId { get; set; }

        public int PatternId { get; set; }
        public Pattern Pattern { get; set; }

        public string yarnWeightKey { get; set; }
        public string yarnWeightValue { get; set; }

        public string needleTypeKey { get; set; }
        public string needleTypeValue { get; set; }

        public string needleSizeKey { get; set; }
        public string needleSizeValue { get; set; }

        public string wearableSizeKey { get; set; }
        public string wearableSizeValue { get; set; }
    }
}
