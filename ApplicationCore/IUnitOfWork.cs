using ApplicationCore.Repositories;

namespace ApplicationCore
{
  public interface IUnitOfWork
  {
      IProductRepository Products { get; }
      int Complete();
    }
}