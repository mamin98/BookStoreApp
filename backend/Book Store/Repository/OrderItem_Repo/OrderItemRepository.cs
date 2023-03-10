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

        // item by Id
        public OrderItem GetById(int id)
        {
            return context.OrderItems.FirstOrDefault(b => b.Id == id);
        }

        // Add new item
        public void Insert(OrderItem item)
        {

            context.OrderItems.Add(item);
            context.SaveChanges();
        }

        // update item details
        public void Edit(OrderItem item, int id)
        {
            item = GetById(id);
            context.Update(item);

            context.SaveChanges();
        }


        // Delete item 
        public void Delete(int id)
        {
            OrderItem item = GetById(id);
            context.OrderItems.Remove(item);

            context.SaveChanges();
        }
    }
}
