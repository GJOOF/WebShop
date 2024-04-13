namespace Webshop.Models
{
    public class Order
    {
        public enum OrderStatuses
        {
            Created,
            Delivering,
            Delivered,
            Canceled
        }
        public string orderId {  get; set; }
        public string userId { get; set; }
        public string productId { get; set; }
        public decimal quantity { get; set; }
        public decimal totalPrice { get; }
        public DateTime? createdDate { get; set; }
        public OrderStatuses status { get; set; }
    }
}
