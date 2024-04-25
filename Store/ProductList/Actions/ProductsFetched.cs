using DemoShop.Models;

namespace DemoShop.Store.ProductList.Actions
{
    public class ProductsFetched
    {
        public ProductsFetched(List<Product> products)
        {
            Products = products;
        }

        public List<Product> Products { get; }
    }
}
