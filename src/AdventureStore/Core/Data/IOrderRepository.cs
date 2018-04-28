using AdventureSports.Core.Models;
using System.Linq;

namespace AdventureSports.Core.Data
{

    public interface IOrderRepository {

        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
