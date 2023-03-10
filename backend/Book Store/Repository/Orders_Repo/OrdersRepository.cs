using Book_Store.Models;

namespace Book_Store.Repository.Orders_Repo
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly BookStoreContext context;

        public OrdersRepository(BookStoreContext _context)
        {
            context = _context;
        }

        // All orders
        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        // order by Id
        public Orders GetById(int id)
        {
            return context.Orders.FirstOrDefault(b => b.Id == id);
        }

        // Add new order
        public void Insert(Orders order)
        {

            context.Orders.Add(order);
            context.SaveChanges();
        }

        // update order details
        public void Edit(Orders order, int id)
        {
            order = GetById(id);
            context.Update(order);

            context.SaveChanges();
        }


        // Delete order 
        public void Delete(int id)
        {
            Orders order = GetById(id);
            context.Orders.Remove(order);

            context.SaveChanges();
        }
    }
}
