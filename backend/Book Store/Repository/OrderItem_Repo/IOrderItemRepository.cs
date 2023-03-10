using Book_Store.Models;

namespace Book_Store.Repository.OrderItem_Repo
{
    public interface IOrderItemRepository
    {
        List<OrderItem> GetAll();
        void Insert(OrderItem item);
    }
}