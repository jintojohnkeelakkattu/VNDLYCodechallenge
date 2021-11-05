using SalesCart.BillCreatorEngine;
using SalesCart.BillCreatorEngine.CostCalculator;
using SalesCart.BillCreatorEngine.TaxCalculator;
using SalesCart.Products;
using SalesCart.Shops;
using SalesCart.Utilities;

namespace SalesCart.PaymentCounter
{
    public class PaymentService
    {
        private IBiller biller;
        private List<Product> productList;
        private Invoice receipt;
        public PaymentService()
        {
            biller = new BillerConcreate(new TaxCalculator());
        }
        public void BillItemsInCart(ShopsProductCart cart)
        {
            productList = cart.GetItemsFromCart();

            foreach (Product p in productList)
            {
                double productTax = biller.CalculateTax(p.Price, p.GetTaxValue(), p.Imported);
                double taxedCost = biller.CalcTotalProductCost(p.Price, productTax);
                // CreateNewReceipt(productList, totalTax, totalAmount);
                p.TaxedCost = taxedCost;
            }
        }
        public Invoice GetReceipt()
        {
            double totalTax = CalcTotalTax(productList);
            double totalAmount = CalcTotalAmount(productList);
            receipt = biller.CreateNewReceipt(productList, totalTax, totalAmount);
            return receipt;
        }
        private double CalcTotalTax(List<Product> prodList)
        {
            double totalTax = 0.0;

            foreach (Product p in prodList)
            {
                totalTax += (p.TaxedCost - p.Price);
            }

            return TaxRounderUtilities.Truncate(totalTax);
        }

        private double CalcTotalAmount(List<Product> prodList)
        {
            double totalAmount = 0.0;

            foreach (Product p in prodList)
            {
                totalAmount += p.TaxedCost;
            }

            return TaxRounderUtilities.Truncate(totalAmount);
        }
    }
}
