using System.Collections.Generic;
using ApplicationCore.Domain;

namespace ApplicationCore.Services
{
    public interface ILocationService
    {
        IEnumerable<WarehouseLocation> GetWarehouseLocations();
    }
}