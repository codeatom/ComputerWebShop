using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ComputerWebShop.Models.Repo;
using ComputerWebShop.Models.Service;
using ComputerWebShop.Models.ViewModel;
using ComputerWebShop.Models.Data;

namespace ComputerWebShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IComputerService _computerService;
        private readonly IShoppingCartService _shoppingCartService;


        public ShoppingCartController(IComputerService computerService, IShoppingCartService shoppingCartService)
        {
            _computerService = computerService;
            _shoppingCartService = shoppingCartService;
        }

        public IActionResult Index()
        {
            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel();

            shoppingCartViewModel.ShoppingCart.ShoppingCartItems = _shoppingCartService.GetShoppingCartItems(); ;
            shoppingCartViewModel.ShoppingCartTotal = _shoppingCartService.CartTotalCost();

            return View(shoppingCartViewModel);
        }

        public IActionResult AddToShoppingCart(int computerId)
        {
            Computer selectedComputer = _computerService.FindById(computerId);

            if (selectedComputer != null)
            {
                _shoppingCartService.AddToCart(selectedComputer, 1);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromShoppingCart(int computerId)
        {
            Computer selectedComputer = _computerService.FindById(computerId);

            if (selectedComputer != null)
            {
                _shoppingCartService.RemoveFromCart(selectedComputer);
            }

            return RedirectToAction("Index");
        }

        public IActionResult ClearShoppingCart()
        {
            _shoppingCartService.ClearCart();

            return RedirectToAction("Index");
        }

    }
}
