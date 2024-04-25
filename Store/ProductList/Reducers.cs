using DemoShop.Store.ProductList.Actions;
using Fluxor;

namespace DemoShop.Store.ProductList
{
    public static class Reducers
    {
        [ReducerMethod(typeof(FetchProducts))]
        public static State ReduceFetchProducts(State state)
            => state with { IsLoading = true };

        [ReducerMethod]
        public static State ReduceProductsRetrieved(State state, ProductsFetched action)
            => state with { IsLoading = false, Products = action.Products };
    }
}
