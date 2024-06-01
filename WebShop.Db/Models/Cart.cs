namespace Webshop.Db.Models
{
    public class Cart
    {
        public Guid Id;
        public Guid UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
    }
}
