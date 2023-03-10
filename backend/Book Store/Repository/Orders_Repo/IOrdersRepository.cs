using Book_Store.Models;

namespace Book_Store.Repository.Orders_Repo
{
    public interface IOrdersRepository
    {
        void Delete(int id);
        void Edit(Orders order, int id);
        List<Orders> GetAll();
        Orders GetById(int id);
        void Insert(Orders order);
    }
}