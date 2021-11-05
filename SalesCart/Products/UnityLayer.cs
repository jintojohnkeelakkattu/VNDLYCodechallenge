using SalesCart.Factory;

namespace SalesCart.Products
{
    public class UnityLayer
    {
        private IProductFactory _objpro;

        public UnityLayer(IProductFactory objpro)
        {
            _objpro = objpro;
        }

        public Product CeateProduct(String name, double price, bool imported, int quantity)
        {
            return _objpro.CeateProduct(name, price, imported, quantity);
        }
    }
}
