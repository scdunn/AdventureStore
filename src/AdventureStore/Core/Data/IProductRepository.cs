using AdventureSports.Core.Models;
using System.Linq;

namespace AdventureSports.Core.Data
{

    public interface IProductRepository {

        IQueryable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
