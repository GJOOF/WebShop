﻿using Webshop.Db.Models;
using Webshop.Models;
using System.Collections.Generic;

namespace Webshop.Helpers
{
    public static class Mapping
    {
        public static List<ProductViewModel> ToProductViewModels(List<Product> products)
        {
            var productViewModels = new List<ProductViewModel>();
            foreach (var product in products)
            {
                ProductViewModel productView = new ProductViewModel()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Cost = product.Cost,
                    Description = product.Description,
                    ImagePath = product.ImagePath,
                };
                productViewModels.Add(productView);
            }
            return productViewModels;
        }
        public static ProductViewModel ToProductViewModel(Product product)
        {
            ProductViewModel productViewModel = new ProductViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Cost = product.Cost,
                Description = product.Description,
                ImagePath = product.ImagePath,
            };
            return productViewModel;
        }
        public static List<CartItemViewModel> ToCartItemViewModels(List<CartItem> cartItems)
        {
            var cartItemViewModels = new List<CartItemViewModel>();
            foreach (var item in cartItems)
            {
                CartItemViewModel cartItemView = new CartItemViewModel()
                {
                    Id = item.Id,
                    Amount = item.Amount,
                    Product = ToProductViewModel(item.Product)
                };
                cartItemViewModels.Add(cartItemView);
            }
            return cartItemViewModels;


        }
        public static CartViewModel ToCartViewModel(Cart cart)
        {
            if (cart == null) return null;
            return new CartViewModel()
            {
                Id = cart.Id,
                UserId = cart.UserId,
                CartItems = ToCartItemViewModels(cart.CartItems)
            };
        }
    }
}
