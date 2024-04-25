using DemoShop.HttpClients;
using DemoShop.Store.ProductList.Actions;
using Fluxor;
using Refit;

namespace DemoShop.Store.ProductList
{
    public class Effects
    {
        private readonly IFakeStoreApi storeApi;

        public Effects(IFakeStoreApi storeApi)
        {
            this.storeApi = storeApi;
        }

        [EffectMethod(typeof(FetchProducts))]
        public async Task FetchProducts(IDispatcher dispatcher)
        {
            await Task.Delay(2000); // exaggerate loading time to show the is loading state

            var products = await storeApi.GetProducts();

            dispatcher.Dispatch(new ProductsFetched(products));
        }
    }
}
