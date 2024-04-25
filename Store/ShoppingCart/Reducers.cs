using DemoShop.Store.ShoppingCart.Actions;
using Fluxor;

namespace DemoShop.Store.ShoppingCart
{
	public static class Reducers
	{
		[ReducerMethod]
		public static State ReduceAddProduct(State state, AddProduct action)
			=> state.AddProduct(action.Product);

        [ReducerMethod]
        public static State ReduceRemoveProduct(State state, RemoveProduct action)
			=> state.RemoveProduct(action.Product, action.Quantity);
	}
}
