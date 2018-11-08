using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Teknolabs.ECommerce.Business.Abstract;
using Teknolabs.ECommerce.MvcWebUI.Models;

namespace Teknolabs.ECommerce.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page = 1, int categoryId = 0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategory(categoryId).Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products
            };
            return View(model);
        }
    }
}