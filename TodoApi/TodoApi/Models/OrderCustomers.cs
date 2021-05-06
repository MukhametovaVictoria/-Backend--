namespace TodoApi.Models
{
    public class OrderCustomers
    {
        public int id { get; set; }
        public int Customer_id { get; set; }
        public string Customer_name { get; set; }
        public System.DateTime Date { get; set; }
    }
}