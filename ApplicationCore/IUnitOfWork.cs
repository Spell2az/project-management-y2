using System;
using System.Runtime.InteropServices;
using ApplicationCore.Repositories;

namespace ApplicationCore
{
  public interface IUnitOfWork : IDisposable
  {
      IProductRepository Products { get; }
      IWarehouseLocationRepository WarehouseLocations { get; }
      int Complete();
    }
}