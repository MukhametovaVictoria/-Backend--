namespace TodoApi.Models
{
    public class OrdersProducts
    {
        public int id { get; set; }
        public int Orders_id { get; set; }
        public int Products_id { get; set; }
        public int Quantity { get; set; }
    }
}