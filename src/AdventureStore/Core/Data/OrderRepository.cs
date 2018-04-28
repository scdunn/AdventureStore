using Microsoft.EntityFrameworkCore;
using AdventureSports.Core.Models;
using System.Linq;

namespace AdventureSports.Core.Data {

    public class OrderRepository : IOrderRepository {
        private StoreDbContext context;

        public OrderRepository(StoreDbContext ctx) {
            context = ctx;
        }

        public IQueryable<Order> Orders => context.Orders
                            .Include(o => o.Lines)
                            .ThenInclude(l => l.Product);

        public void SaveOrder(Order order) {
            context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderID == 0) {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}
