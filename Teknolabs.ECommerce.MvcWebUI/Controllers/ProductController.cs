using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
            var products = _productService.GetByCategory(categoryId);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = categoryId,
                CurrentPage = page


            };
            return View(model);
        }

        //public string Session()
        //{
        //    HttpContext.Session.SetString("city", "Ankara");
        //    HttpContext.Session.SetInt32("city", 32);

        //    HttpContext.Session.GetString("city");
        //    HttpContext.Session.GetInt32("city");

        //    //biz sessionda obje tutarız. obje to string yaparsak referans kayboluyor


        //}
         
    }
}