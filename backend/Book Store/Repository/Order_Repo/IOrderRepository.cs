using Book_Store.Models;

namespace Book_Store.Repository.Orders_Repo
{
    public interface IOrderRepository
    {
        void Delete(int id);
        void Edit(Order order, int id);
        List<Order> GetAll();
        Order GetById(int id);
        void Insert(Order order);
    }
}