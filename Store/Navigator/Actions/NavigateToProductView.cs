namespace DemoShop.Store.Navigator.Actions
{
    public class NavigateToProductView
    {
        public NavigateToProductView(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
    }
}
