using System.Collections.Generic;
using System.Threading.Tasks;
using ProductApi.Models;


namespace ProductApi.Repositories
{
    public interface IProductRepository
    {
        Task<Product> Get(int id);
        Task<IEnumerable<Product>> GetAll();
        Task Add(Product product);
        Task Delete(int id);
        Task Update(Product product);
    }
}