﻿using ComputerWebShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerWebShop.Models.ViewModel
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }

        public ShoppingCartViewModel()
        {
            ShoppingCart = new ShoppingCart();
        }
    }
}
