using Core.Entities;
using Core.Entities.AdventureWorks;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> Details(int? id);
    }
}
