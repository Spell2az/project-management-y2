using System.Data.Entity;
using ApplicationCore.Domain;
using ApplicationCore.Repositories;

namespace DAL.Repositories
{
    public class WarehouseLocationRepository : Repository<WarehouseLocation>, IWarehouseLocationRepository
    {
        public WarehouseLocationRepository(DbContext context) : base(context)
        {
        }
    }
}