using SalesCart.Products;

namespace SalesCart.Shops
{
    public class ShopsProductCart
    {
        private List<Product> productList { get; set; }

        public ShopsProductCart()
        {
            productList = new List<Product>();
        }

        public void AddItemToCart(Product product)
        {
            productList.Add(product);
        }

        public List<Product> GetItemsFromCart()
        {
            return productList;
        }

    }

}

