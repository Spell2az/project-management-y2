using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationCore.Services;

namespace StoreManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {

        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService ?? throw new ArgumentNullException("productService");
        }
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }


        // GET: Product
        public ActionResult Details(int id)
        {
            var product = productService.GetProductById(id);

            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        // GET: Product
        public ActionResult Edit(int id)
        {
            var product = productService.GetProductById(id);

            if (product == null)
                return HttpNotFound();

            return View(product);
        }
    }
}