using ApplicationCore;
using ApplicationCore.Repositories;
using DAL.Repositories;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {


        private readonly ApplicationDbContext context;
        private IProductRepository products;
        private IWarehouseLocationRepository warehouseLocations;

        public IProductRepository Products
        {
            get {
                return products ?? (products = new ProductRepository(context));
            }
        }

        public IWarehouseLocationRepository WarehouseLocations
        {
            get { return warehouseLocations ?? (warehouseLocations = new WarehouseLocationRepository(context));}
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