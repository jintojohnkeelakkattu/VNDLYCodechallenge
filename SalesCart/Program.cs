using SalesCart;
using SalesCart.Utilities;

class Program
{

    static void Main(string[] args)
    {
        do
        {
            ShoppingMart mart = new ShoppingMart();
            mart.GetSalesOrder();
            mart.CheckOutCounter();
        }
        while (CommonUtilities.IsAddAnotherProduct());
    }


}
