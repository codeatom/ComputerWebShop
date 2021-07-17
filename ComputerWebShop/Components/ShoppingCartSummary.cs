using ComputerWebShop.Models.Data;
using ComputerWebShop.Models.Service;
using ComputerWebShop.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerWebShop.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly IShoppingCartService _shoppingCartService;


        public ShoppingCartSummary(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        public IViewComponentResult Invoke()
        {
            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel();

            shoppingCartViewModel.ShoppingCart.ShoppingCartItems = _shoppingCartService.GetShoppingCartItems();
            shoppingCartViewModel.ShoppingCartTotal = _shoppingCartService.CartTotalCost();

            return View(shoppingCartViewModel);
        }
    }
}
