using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCart.BillCreatorEngine.TaxCalculator
{
    public  interface ITaxCalculator
    {
        double CalculateTaxAmount(double price, double tax, bool imported);
    }
}
