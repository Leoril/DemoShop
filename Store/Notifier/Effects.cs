using DemoShop.Store.Notifier.Actions;
using Fluxor;
using Radzen;

namespace DemoShop.Store.Notifier
{
    public class Effects
    {
        private readonly NotificationService notificationService;

        public Effects(NotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        [EffectMethod]
        public Task ShowNotification(ShowNotification action, IDispatcher _)
        {
            notificationService.Notify(action.NotificationMessage);

            return Task.CompletedTask;
        }
    }
}
