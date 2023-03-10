using Book_Store.Models;

namespace Book_Store.Repository.Orders_Repo
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BookStoreContext context;

        public OrderRepository(BookStoreContext _context)
        {
            context = _context;
        }

        // All orders
        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        // order by Id
        public Order GetById(int id)
        {
            return context.Orders.FirstOrDefault(b => b.Id == id);
        }

        // Add new order
        public void Insert(Order order)
        {

            context.Orders.Add(order);
            context.SaveChanges();
        }

        // update order details
        public void Edit(Order order, int id)
        {
            order = GetById(id);
            context.Update(order);

            context.SaveChanges();
        }


        // Delete order 
        public void Delete(int id)
        {
            Order order = GetById(id);
            context.Orders.Remove(order);

            context.SaveChanges();
        }
    }
}
