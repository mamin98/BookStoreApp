using Book_Store.Models;

namespace Book_Store.Repository.OrderItem_Repo
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly BookStoreContext context;

        public OrderItemRepository(BookStoreContext _context)
        {
            context = _context;
        }
        
        // All items
        public List<OrderItem> GetAll()
        {
            return context.OrderItems.ToList();
        }


        // Add new item
        public void Insert(OrderItem item)
        {

            context.OrderItems.Add(item);
            context.SaveChanges();
        }

    }
}
