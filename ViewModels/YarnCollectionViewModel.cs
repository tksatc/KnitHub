using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnitHub.Models;

namespace KnitHub.ViewModels
{
    public class YarnCollectionViewModel
    {
        public Yarn Yarn { get; set; }
        public YarnDetail YarnDetail { get; set; }

        public double? CalcTotalYardage()
        {
            double? totalYardageCalculation = Yarn.SkeinYardage * YarnDetail.QuantityOfSkeins;
            return totalYardageCalculation;
        }
    }
}
