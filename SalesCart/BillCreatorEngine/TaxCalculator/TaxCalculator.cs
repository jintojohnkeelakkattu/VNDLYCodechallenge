using SalesCart.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCart.BillCreatorEngine.TaxCalculator
{
    public class TaxCalculator : ITaxCalculator
    {
        public double CalculateTaxAmount(double price, double localTax, bool imported)
        {
            double tax = price * localTax;

            if (imported)
                tax += (price * 0.5);

            //rounds off to nearest 0.05;
            tax = TaxRounderUtilities.RoundOff(tax);

            return tax;
        }
    }
}
