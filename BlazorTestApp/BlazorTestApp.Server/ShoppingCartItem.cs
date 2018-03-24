namespace BlazorTestApp.Server.Controllers
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double UnitPrice { get; set; }

        public int Units { get; set; }
    }
}