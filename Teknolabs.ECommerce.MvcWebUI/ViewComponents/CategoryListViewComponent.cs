using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using Teknolabs.ECommerce.Business.Abstract;
using Teknolabs.ECommerce.MvcWebUI.Models;

namespace Teknolabs.ECommerce.MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            CategoryListViewModel model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["categoryId"])
            };
            return View(model);
        }
}
}
