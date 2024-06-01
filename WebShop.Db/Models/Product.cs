﻿namespace Webshop.Db.Models
{
    public class Product
    {
        private static int instanceCounter = 0;
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public List<CartItem> CartItems { get; set; }
        public Product()
        {
            CartItems = new List<CartItem>();
        }
    }
}
