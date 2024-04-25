using DemoShop.Models;
using Fluxor;

namespace DemoShop.Store.ShoppingCart
{
	[FeatureState]
	public record State
	{
        public Dictionary<Product, int> ProductTotals { get; set; } = new();

        public decimal TotalPrice
            => ProductTotals.Sum(x => x.Value * x.Key.Price);

		public int TotalCount
			=> ProductTotals.Sum(x => x.Value);

        public State AddProduct(Product product)
        {
            ProductTotals.TryGetValue(product, out var total);

            ProductTotals[product] = total + 1;

            return this with { ProductTotals = ProductTotals };
        }

		public State RemoveProduct(Product product, int quantity)
		{
			if (ProductTotals.TryGetValue(product, out var total) && total > 0)
			{
				var newTotal = total - quantity;
				if (newTotal > 0)
					ProductTotals[product] = total - 1;
				else
					ProductTotals.Remove(product);

				return this with { ProductTotals = ProductTotals };
			}

			return this;
		}
	}
}
