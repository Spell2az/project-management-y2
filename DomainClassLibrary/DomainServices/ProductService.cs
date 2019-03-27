using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DomainClassLibrary.Entities;
using ManagementApp.DAL;

namespace DomainClassLibrary.DomainServices
{
  public class ProductService
  {
    private readonly AppContext context;
    public ProductService(AppContext context)
    {
      this.context = context;
    }

    public async Task<List<Product>> GetProducts()
    {
      return await context.Products.ToListAsync();
    }

  }
}