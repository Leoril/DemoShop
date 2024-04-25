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
        public IStateSelection<State, Product> Product { get; set; }

        [Inject]
        public IStateSelection<CartState, int> TotalProductsInCart { get; set; }

        [Parameter]
        public int ProductId { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            Product.Select(x => x.Products.First(x => x.Id == ProductId));
            TotalProductsInCart
                .Select(x => 
                    x.ProductTotals.TryGetValue(
                        Product.Value, 
                        out var productTotals) ? productTotals : 0);
        }

        protected void AddProduct()
            => Dispatcher.Dispatch(new Store.ShoppingCart.Actions.AddProduct(Product.Value));

        protected void RemoveProduct()
            => Dispatcher.Dispatch(new Store.ShoppingCart.Actions.RemoveProduct(Product.Value));
    }
}