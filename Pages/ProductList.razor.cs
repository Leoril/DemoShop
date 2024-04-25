using DemoShop.Store.ProductList;
using Fluxor;
using Microsoft.AspNetCore.Components;
using DemoShop.Store.ProductList.Actions;
using DemoShop.Store.Navigator.Actions;
using DemoShop.Models;
using DemoShop.Store.ShoppingCart.Actions;

namespace DemoShop.Pages
{
    public partial class ProductList : FluxorComponent
    {
        [Inject]
        public IState<State> State { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            if (State.Value.Products.Count == 0)
                Dispatcher.Dispatch(new FetchProducts());
        }

        protected void NavigateToProduct(int id)
            => Dispatcher.Dispatch(new NavigateToProductView(id));

        private void AddProduct(Product product)
            => Dispatcher.Dispatch(new AddProduct(product));
    }
}
