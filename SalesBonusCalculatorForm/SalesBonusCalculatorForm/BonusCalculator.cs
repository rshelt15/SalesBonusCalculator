using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesBonusCalculatorForm
{
    internal class BonusCalculator
    { 
        public decimal BonusRate { get; private set; } // Bonus rate is multiplied by budget hours to calculate the payroll bonus
        public decimal TotalSalesBonus { get; private set; }
        public BonusCalculator(decimal bonusRate)
        {
            BonusRate = bonusRate;
        }
        public decimal CalculateSalesBonus(decimal BH) 
        {
            decimal salesBonus;
            decimal bonusRate = BonusRate;
            decimal minBonus = 20; // Add feature for changing this
            if (BH * bonusRate < minBonus)
            {
                salesBonus = minBonus;
            }
            else
            {
                salesBonus = BH * bonusRate;
            }
            return salesBonus;
        }
        public void UpdateBonusRate(decimal newRate)
        {
            BonusRate = newRate;
        }
        public void Reset()
        {
            TotalSalesBonus = 0;
        }
    }
}
