using StockStore.Models;
using System.Text.Json;

namespace StockStore.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private List<Sock> _socks = new();


        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<List<Sock>> GetProductsAsync()
        {
            if (_socks == null || !_socks.Any())
            {
                try
                {
                    var jsonData = await _httpClient.GetStringAsync("data/socks.json");
                    _socks = JsonSerializer.Deserialize<List<Sock>>(jsonData) ?? new List<Sock>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading socks.json: {ex.Message}");
                }
            }
            return _socks;
        }



        public async Task<Sock> GetProductByIdAsync(int id)
        {
            var products = await GetProductsAsync();
            return products.FirstOrDefault(s => s.Id == id);
        }
    }
}
