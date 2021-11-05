using SalesCart.BillCreatorEngine;
using SalesCart.PaymentCounter;
using SalesCart.Products;
using SalesCart.Shops;
using SalesCart.Utilities;

namespace SalesCart
{
    public class ShoppingMart
    {
        private ShopsProductCart shoppingCart;
        private ShoppingMartShelf storeShelf;
        private PaymentService paymentService;

        public ShoppingMart()
        {
            shoppingCart = new ShopsProductCart();
            storeShelf = new ShoppingMartShelf();
            paymentService = new PaymentService();
        }

        public void RetrieveOrderAndPlaceInCart(string name, double price, bool imported, int quantity)
        {
            Product product = storeShelf.SearchItemsFromShelf(name, price, imported, quantity);
            shoppingCart.AddItemToCart(product);
        }

        public void GetSalesOrder()
        {
            do
            {
                string name = GetProductName();
                double price = GetProductPrice();
                bool imported = IsProductImported();
                int quantity = GetQuantity();
                RetrieveOrderAndPlaceInCart(name.ToLower(), price, imported, quantity);
            }
            while (CommonUtilities.IsAddAnotherProduct());
        }

        public String GetProductName()
        {
            Console.WriteLine("Enter the product name:\n");
            return Console.ReadLine();
        }

        public double GetProductPrice()
        {
            Console.WriteLine("Enter the product price:\n");
            var input = Console.ReadLine();
            double val;
            while (!(double.TryParse(input, out val)))
            {
                Console.WriteLine("Invalid price. Enter a number");
            }

            return val;
        }

        public bool IsProductImported()
        {
            Console.WriteLine("Is product imported or not?(Y/N)\n");
            var input = Console.ReadLine().ToUpperInvariant();
            bool isValid = false;

            while (!isValid)
            {
                if (input == "Y")
                    isValid = true;
                else if (input == "N")
                    isValid = true;
                else
                    Console.WriteLine("Invalid input. Enter (Y/N)");
            }

            if (input == "Y")
                return true;
            else
                return false;
        }

        public int GetQuantity()
        {
            Console.WriteLine("Enter the quantity:\n");
            var input = Console.ReadLine();
            int intVal;
            while (!(int.TryParse(input, out intVal)))
            {
                Console.WriteLine("Invalid input. Enter a integer");
            }
            return intVal;
        }

        public void CheckOutCounter()
        {
            paymentService.BillItemsInCart(shoppingCart);
            Invoice invoice = paymentService.GetReceipt();
            Console.WriteLine(invoice.InvoicePrinter());
        }
    }
}

