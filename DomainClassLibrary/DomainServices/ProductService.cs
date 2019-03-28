using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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

    public async void AddProduct(Product product)
    {
      context.Products.Add(product);
      await context.SaveChangesAsync();
    }

    public async void UpdateProduct(Product product)
    {
      context.Products.AddOrUpdate(product);
      await context.SaveChangesAsync();
    }

    public async Task<Product> GetProduct(int id)
    {
      return await context.Products.FirstOrDefaultAsync(u => u.Id == id);
    }
  }
}