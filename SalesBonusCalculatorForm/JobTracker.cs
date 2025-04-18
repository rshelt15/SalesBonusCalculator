using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesBonusCalculatorForm
{
    public class JobTracker
    {
        public int JobIndex { get; private set; } = 1;
        public decimal TotalSales { get; private set; } = 0;
        public decimal TotalBH { get; private set; } = 0;

        public void NextJob()
        {
            JobIndex++;
        }
        public void PrevJob()
        {
            if (JobIndex > 1)
            {
                JobIndex--;
            }
        }
        public void UpdateTotalSales(decimal saleAmount)
        {
            TotalSales = TotalSales + saleAmount;
        }
        public void UpdateTotalBH(decimal BH)
        {
            TotalBH = TotalBH + BH;
        }
        public void Reset()
        {
            JobIndex = 1;
            TotalSales = 0;
            TotalBH = 0;
        }
    }
}
