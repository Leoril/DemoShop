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
        public IStateSelection<State, Product> ProductSlice { get; set; }

        [Inject]
        public IStateSelection<CartState, int> TotalProductsInCartSlice { get; set; }

        [Parameter]
        public int ProductId { get; set; }

        public Product Product => ProductSlice.Value;

        public int TotalProductsInCart => TotalProductsInCartSlice.Value;

        protected override void OnInitialized()
        {
            base.OnInitialized();

            ProductSlice.Select(x => x.Products.First(x => x.Id == ProductId));
            TotalProductsInCartSlice
                .Select(x =>
                    x.ProductTotals.TryGetValue(
                        ProductSlice.Value,
                        out var productTotals) ? productTotals : 0);
        }

        protected void AddProduct()
            => Dispatcher.Dispatch(new Store.ShoppingCart.Actions.AddProduct(Product));

        protected void RemoveProduct()
            => Dispatcher.Dispatch(new Store.ShoppingCart.Actions.RemoveProduct(Product));
    }
}