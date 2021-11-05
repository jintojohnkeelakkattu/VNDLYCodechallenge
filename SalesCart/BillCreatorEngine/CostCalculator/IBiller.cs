using SalesCart.Products;

namespace SalesCart.BillCreatorEngine.CostCalculator
{
    internal interface IBiller
    {
        double CalculateTax(double price, double tax, bool imported);
        double CalcTotalProductCost(double price, double tax);
        Invoice CreateNewReceipt(List<Product> productList, double totalTax, double totalAmount);
    }
}
