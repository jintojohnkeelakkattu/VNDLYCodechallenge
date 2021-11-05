using SalesCart.Products;

namespace SalesCart.Factory
{
    public interface IProductFactory
    {
        Product CeateProduct(String name, double price, bool imported, int quantity);
    }
}
