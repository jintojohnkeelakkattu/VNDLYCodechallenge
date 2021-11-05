using SalesCart.Products;

namespace SalesCart.Factory
{
    public abstract class ProductFactory: IProductFactory
    {
        public abstract Product CeateProduct(String name, double price, bool imported, int quantity);
    }
}
