using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace ClientEshop.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext ctx;
        public ShopController()
        {
            ctx = ApplicationDbContext.Create();
        }
        // GET: Shop
        public ActionResult Index()
        {
            var unitOfWork = new UnitOfWork(ctx);
            var products = unitOfWork.Products.GetAll();
            return View(products);
        }
    }
}