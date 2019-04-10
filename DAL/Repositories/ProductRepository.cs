using System.Data.Entity;
using ApplicationCore.Domain;
using ApplicationCore.Repositories;

namespace DAL.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }
    }
}