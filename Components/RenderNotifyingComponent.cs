using DemoShop.Store.Notifier.Actions;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace DemoShop.Components
{
    public class RenderNotifyingComponent : FluxorComponent
    {
        [Inject]
        public IDispatcher Dispatcher { get; private set; }

        protected override bool ShouldRender()
        {
            var result = base.ShouldRender();

            if (result)
                Dispatcher.Dispatch(new ShowNotification(new NotificationMessage
                {
                    Severity = NotificationSeverity.Info,
                    Duration = 1000,
                    Detail = $"{this.GetType().Name} component was re-rendered.",
                    Summary = "Re-render notification",
                    Style = "position: fixed; left: 50%"
                }));

            return result;
        }
    }
}
