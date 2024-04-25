using DemoShop.Models;

namespace DemoShop.HttpClients
{
    public interface IFakeStoreApi
    {
        [Get("/products")]
        Task<List<Product>> GetProducts();
    }
}
