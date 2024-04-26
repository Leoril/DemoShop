using DemoShop.Models;
using DemoShop.Store.ProductList;
using Microsoft.AspNetCore.Components;
using Fluxor;
using CartState = DemoShop.Store.ShoppingCart.State;

namespace DemoShop.Pages
{
    public partial class ProductView : FluxorComponent
    {
        [Inject]
        public IDispatcher Dispatcher { get; set; }

        [Inject]
        public IState<State> State { get; set; }

        [Inject]
        public IState<CartState> CartState { get; set; }

        [Parameter]
        public int ProductId { get; set; }

        public Product Product => State.Value.Products.Find(x => x.Id == ProductId) ?? new();

        public int TotalProductsInCart => CartState.Value.ProductTotals.TryGetValue(Product, out var productTotals)
            ? productTotals : 0;

        protected void AddProduct()
            => Dispatcher.Dispatch(new Store.ShoppingCart.Actions.AddProduct(Product));

        protected void RemoveProduct()
            => Dispatcher.Dispatch(new Store.ShoppingCart.Actions.RemoveProduct(Product));
    }
}