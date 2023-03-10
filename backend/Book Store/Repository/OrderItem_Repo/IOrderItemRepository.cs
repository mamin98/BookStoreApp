using Book_Store.Models;

namespace Book_Store.Repository.OrderItem_Repo
{
    public interface IOrderItemRepository
    {
        void Delete(int id);
        void Edit(OrderItem item, int id);
        List<OrderItem> GetAll();
        OrderItem GetById(int id);
        void Insert(OrderItem item);
    }
}