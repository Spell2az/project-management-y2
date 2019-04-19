using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationCore.Services;
using DAL;

namespace ClientEshop.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService productService;
       
        public ShopController(IProductService productService)
        {
            this.productService = productService ?? throw new ArgumentNullException("productService");
        }
        // GET: Shop
        public ActionResult Index()
        {
            var products = productService.GetProducts();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = productService.GetProductById(id);
            return View(product);
        }


    }
}