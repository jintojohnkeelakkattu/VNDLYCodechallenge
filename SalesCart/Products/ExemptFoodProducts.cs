namespace SalesCart.Products
{
    public class ExemptFoodProducts : Product
    {
        public ExemptFoodProducts()
    : base()
        {
        }

        public ExemptFoodProducts(String name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {

        }

        public override double GetTaxValue()
        {
            return 0;
        }
    }
}
