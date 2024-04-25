using CartState = DemoShop.Store.ShoppingCart.State;
using Microsoft.AspNetCore.Components;
using Fluxor;
using DemoShop.Models;

namespace DemoShop.Pages
{
    public partial class CartSummary : FluxorComponent
    {
        [Inject]
        public IDispatcher Dispatcher { get; set; }

        [Inject]
        public IState<CartState> CartState { get; set; }

        public void RemoveProduct(KeyValuePair<Product, int> info)
            => Dispatcher.Dispatch(new Store.ShoppingCart.Actions.RemoveProduct(info.Key, info.Value));
    }
}
