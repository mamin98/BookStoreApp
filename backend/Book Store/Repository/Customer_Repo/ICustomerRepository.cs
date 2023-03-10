using Book_Store.Models;

namespace Book_Store.Repository.Customers_Repo
{
    public interface ICustomerRepository
    {
        void Delete(int id);
        List<Customer> GetAll();
        Customer GetById(int id);
    }
}