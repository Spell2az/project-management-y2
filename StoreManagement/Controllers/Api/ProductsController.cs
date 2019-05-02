using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApplicationCore.Domain;
using ApplicationCore.Services;
using StoreManagement.Models;

namespace StoreManagement.Controllers.Api
{
    public class ProductsController : ApiController
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService ?? throw new ArgumentNullException("productService");
        }
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var products = productService
                .GetProducts()
                .Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Category = p.Category.ToString(),
                Price = p.Price,
            });
            
            return Ok(products);
        }

    }
}