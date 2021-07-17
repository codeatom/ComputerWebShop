using ComputerWebShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerWebShop.Models.ViewModel
{
    public class OrderViewModel
    {
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public decimal TotalCost { get; set; }

        public OrderViewModel()
        {
            ShoppingCartItems = new List<ShoppingCartItem>();
        }
    }
}
