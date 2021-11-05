using SalesCart.Products;

namespace SalesCart.Factory
{
    internal class NonExcemptProductConcreate : ProductFactory
    {
        public override Product CeateProduct(string name, double price, bool imported, int quantity)
        {
            return new Products.NonExemptFoddProducts(name, price, imported, quantity);
        }
    }
}
