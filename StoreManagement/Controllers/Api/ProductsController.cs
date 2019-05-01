using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApplicationCore.Domain;
using ApplicationCore.Services;

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
        public IEnumerable<Product> Get()
        {
            var products = productService.GetProducts();
            return products;
        }

        // GET api/<controller>/5
        public Product GetProduct(int id)
        {
            var product = productService.GetProductById(id);

            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }

        // POST api/<controller>
        [HttpPost]
        public Product CreateProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            productService.CreateProduct(product);

            return product;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}