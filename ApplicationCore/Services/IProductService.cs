using System.Collections.Generic;
using ApplicationCore.Domain;

namespace ApplicationCore.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        IEnumerable<Product> GetProductsByCategory(Categories category);
    }
}