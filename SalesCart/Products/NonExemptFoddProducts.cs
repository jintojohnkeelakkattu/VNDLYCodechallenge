namespace SalesCart.Products
{
    public class NonExemptFoddProducts : Product
    {
        public NonExemptFoddProducts()
            : base()
        {
        }
        public NonExemptFoddProducts(String name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }
        public override double GetTaxValue()
        {
            return 0.10;
        }
    }

}
