using SalesCart.Factory;
using SalesCart.Products;
using Unity;

namespace SalesCart.Shops
{
    public class ShoppingMartShelf
    {
        private readonly Dictionary<string, int> productItems;
        UnityContainer IU = null;

        public ShoppingMartShelf()
        {
            IU = new UnityContainer();
            RegisterDependency();
            productItems = new Dictionary<string, int>();
            AddProductItemsToShelf("book", 1);
            AddProductItemsToShelf("chocolate bar", 1);
            AddProductItemsToShelf("box of chocolates", 1);
            AddProductItemsToShelf("packet of headache pills", 1);
            AddProductItemsToShelf("music cd", 2);
            AddProductItemsToShelf("bottle of perfume", 2);
        }
        public void RegisterDependency()
        {
            /* Register a type*/
            IU.RegisterType<UnityLayer>();
            IU.RegisterType<ExcemptProductConcreate>();
            IU.RegisterType<NonExcemptProductConcreate>();
        }
        public void AddProductItemsToShelf(string productItem, int data)
        {
            productItems.Add(productItem, data);
        }

        public Product SearchItemsFromShelf(string name, double price, bool imported, int quantity)
        {
            int peoductType = (int)productItems[name];
            if (peoductType == 1)
            {
                IU.RegisterType<IProductFactory, ExcemptProductConcreate>();
            }
            else
            {
                IU.RegisterType<IProductFactory, NonExcemptProductConcreate>();
            }
            UnityLayer objDL = IU.Resolve<UnityLayer>();
            Product productItem = objDL.CeateProduct(name, price, imported, quantity);
            return productItem;
        }

    }
}

