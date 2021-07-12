using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductApi.Models;

namespace ProductApi.Data
{
    public interface IDataContext
    {
        DbSet<Product> Products {get; set;}

        Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
         
    }
}