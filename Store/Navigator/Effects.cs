using DemoShop.Store.Navigator.Actions;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace DemoShop.Store.Navigator
{
    public class Effects
    {
        private readonly NavigationManager navigationManager;

        public Effects(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        [EffectMethod]
        public Task NavigateToProductView(NavigateToProductView action, IDispatcher _)
        {
            navigationManager.NavigateTo($"/product/{action.ProductId}");

            return Task.CompletedTask;
        }
    }
}
