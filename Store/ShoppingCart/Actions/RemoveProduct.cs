using DemoShop.Models;

namespace DemoShop.Store.ShoppingCart.Actions
{
	public class RemoveProduct
	{
        public RemoveProduct(Product product, int quantity = 1)
        {
			Product = product;
            Quantity = quantity;
        }

		public Product Product { get; }
        public int Quantity { get; }
    }
}
