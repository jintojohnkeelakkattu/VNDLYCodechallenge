using SalesCart.Products;

namespace SalesCart.Factory
{
    public class ExcemptProductConcreate : ProductFactory
    {
        public override Product CeateProduct(string name, double price, bool imported, int quantity)
        {
            return new Products.ExemptFoodProducts(name, price, imported, quantity);
        }
    }
}
