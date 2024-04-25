using DemoShop.Pages;
using DemoShop.Store.ShoppingCart.Actions;
using Fluxor;
using Radzen;

namespace DemoShop.Store.ShoppingCart
{
    public class Effects
    {
        private readonly DialogService dialogService;

        public Effects(DialogService dialogService)
        {
            this.dialogService = dialogService;
        }

        [EffectMethod(typeof(ShowSummary))]
        public Task ShowSummary(IDispatcher _)
        {
            dialogService.OpenSideAsync<CartSummary>("Cart summary", options: new SideDialogOptions
            {
                Position = DialogPosition.Right,
                ShowMask = false
            });

            return Task.CompletedTask;
        }
    }
}
