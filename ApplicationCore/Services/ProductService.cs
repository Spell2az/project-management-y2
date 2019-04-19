using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Domain;

namespace ApplicationCore.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException("unitOfWork");
        }

        public IEnumerable<Product> GetProducts()
        {
            return unitOfWork.Products.GetAll();
        }

        public Product GetProductById(int id)
        {
            return unitOfWork.Products.Get(id);
        }

        public IEnumerable<Product> GetProductsByCategory(Categories category)
        {
            return unitOfWork.Products.Find(p => p.Category == category);
        }
    }
}
