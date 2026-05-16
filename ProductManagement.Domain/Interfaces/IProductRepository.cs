using ProductManagement.Domain.Entities;

namespace ProductManagement.Domain.Interfaces
{
    public interface IProductRepository
    { 
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
        Task<Product?> GetByIdAsync(Guid id);
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
