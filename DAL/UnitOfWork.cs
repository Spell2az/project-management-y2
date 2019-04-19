using ApplicationCore;
using ApplicationCore.Repositories;
using DAL.Repositories;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {


        private readonly ApplicationDbContext context;
        private IProductRepository products;

        public IProductRepository Products
        {
            get {
                return products ?? (products = new ProductRepository(context));
            }
        }

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;

        }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }

   
}