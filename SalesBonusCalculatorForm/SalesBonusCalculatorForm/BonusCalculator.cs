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
        public bool BonusIsDoubled {  get; private set; }
        public BonusCalculator(decimal bonusRate)
        {
            BonusRate = bonusRate;
        }

        public decimal CalculateSalesBonus(decimal BH)
        {
            decimal salesBonus;
            decimal bonusRate = BonusRate;
            decimal minBonus = 20;
            if (BonusIsDoubled)
            {
                bonusRate = bonusRate * 2;
                minBonus = minBonus * 2;
            }
            if(BH <= 0)
            {
                salesBonus = 0;
            }
            else if (BH * bonusRate < minBonus)
            {
                salesBonus = minBonus;
            }
            else
            {
                salesBonus = BH * bonusRate;
            }
            UpdateSalesBonus(salesBonus);
            return salesBonus;
        }
        public decimal CalculateIndividualSalesBonus(decimal BH) // THIS IS A COPY OF CalculateSalesBonus REWRITE THIS TO ONLY CALCULATE THE SALES BONUS FOR THAT JOB AND WRITE A NEW METHOD | METHOD SHOULD ONLY DO ONE THING
        {
            decimal salesBonus;
            decimal bonusRate = BonusRate;
            decimal minBonus = 20;
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
        public void UpdateSalesBonus(decimal saleBonus)
        {
            TotalSalesBonus = TotalSalesBonus + saleBonus;
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
