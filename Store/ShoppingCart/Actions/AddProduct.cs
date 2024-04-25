using DemoShop.Models;

namespace DemoShop.Store.ShoppingCart.Actions
{
	public class AddProduct
	{
        public AddProduct(Product product)
        {
			Product = product;
		}

		public Product Product { get; }
	}
}
