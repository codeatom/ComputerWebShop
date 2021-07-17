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
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryMenu(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            CategoryViewModel categoryViewModel = _categoryService.All();

            categoryViewModel.CategoryList = _categoryService.All().CategoryList.OrderBy(c => c.Name).ToList();

            return View(categoryViewModel);
        }
    }
}
