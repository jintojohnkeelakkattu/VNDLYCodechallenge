using SalesCart.Products;

namespace SalesCart.BillCreatorEngine
{
    public class Invoice
    {
        private List<Product> ProductList { get; set; }
        private double TotalSalesTax { get; set; }
        private double TotalAmount { get; set; }

        public Invoice(List<Product> prod, double tax, double amount)
        {
            ProductList = prod;
            TotalSalesTax = tax;
            TotalAmount = amount;
        }

        public int GetTotalNumberOfItems()
        {
            return ProductList.Count;
        }

        public string InvoicePrinter()
        {
            String res = "";
            foreach (var p in ProductList)
            {
                res += (p.ToString() + "\n");
            }
            Console.WriteLine("***************");
            res += "Total Sales Tax = " + TotalSalesTax + "\n";
            res += "Total Amount = " + TotalAmount + "\n";
            Console.WriteLine("***************");
            return res;
        }
    }
}
