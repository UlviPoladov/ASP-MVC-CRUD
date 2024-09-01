using WebApplication8.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication8.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<Product> GetByIdAsync(int id);

    }
}
