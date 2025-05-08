using StockStore.Models;

namespace StockStore.Services
{
    public interface IProductService
    {
        Task<List<Sock>> GetProductsAsync();
        Task<Sock> GetProductByIdAsync(int id);
    }
}
