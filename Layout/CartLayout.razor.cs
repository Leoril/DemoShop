using DemoShop.Store.ShoppingCart.Actions;
using Fluxor;
using Microsoft.AspNetCore.Components;


namespace DemoShop.Layout
{
    public partial class CartLayout : FluxorComponent
    {
        [Inject]
        public IDispatcher Dispatcher { get; set; }

        private void ShowSummary()
            => Dispatcher.Dispatch(new ShowSummary());
    }
}
