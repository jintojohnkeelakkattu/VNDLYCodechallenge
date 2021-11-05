using SalesCart.BillCreatorEngine.TaxCalculator;
using SalesCart.Products;
using SalesCart.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCart.BillCreatorEngine.CostCalculator
{
    public class BillerConcreate: IBiller
    {
        ITaxCalculator taxCalculator;

        public BillerConcreate(ITaxCalculator taxCalc)
        {
            taxCalculator = taxCalc;
        }

        public double CalculateTax(double price, double tax, bool imported)
        {

            double totalProductTax = taxCalculator.CalculateTaxAmount(price, tax, imported);
            return totalProductTax;
        }
        public double CalcTotalProductCost(double price, double tax)
        {
            return TaxRounderUtilities.Truncate(price + tax);
        }
        public Invoice CreateNewReceipt(List<Product> productList, double totalTax, double totalAmount)
        {
            return new Invoice(productList, totalTax, totalAmount);
        }
    }
}
