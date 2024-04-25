using Fluxor;

namespace DemoShop.DependencyInjection
{
    public static class Fluxor
    {
        public static IServiceCollection ConfigureFluxor(this IServiceCollection services)
            => services.AddFluxor(options =>
                options.ScanAssemblies(typeof(IAssemblyAnchor).Assembly)
                .UseReduxDevTools());
    }
}
