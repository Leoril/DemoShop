using Radzen;

namespace DemoShop.Store.Notifier.Actions
{
    public class ShowNotification
    {
        public ShowNotification(NotificationMessage notificationMessage)
        {
            NotificationMessage = notificationMessage;
        }

        public NotificationMessage NotificationMessage { get; }
    }
}
