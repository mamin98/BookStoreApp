using Book_Store.Models;

namespace Book_Store.Repository.Customers_Repo
{
    public interface ICustomersRepository
    {
        void Delete(int id);
        List<Customers> GetAll();
        Customers GetById(int id);
    }
}