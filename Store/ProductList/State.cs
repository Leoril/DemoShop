using DemoShop.Models;
using Fluxor;

namespace DemoShop.Store.ProductList
{
    [FeatureState]
    public record State
    {
        public bool IsLoading { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
