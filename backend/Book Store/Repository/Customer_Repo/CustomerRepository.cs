using Book_Store.Models;

namespace Book_Store.Repository.Customers_Repo
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BookStoreContext context;

        public CustomerRepository(BookStoreContext _context)
        {
            context = _context;
        }

        // All Customers
        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        // Customer by Id
        public Customer GetById(int id)
        {
            return context.Customers.FirstOrDefault(b => b.ID == id);
        }


        // Delete Customer 
        public void Delete(int id)
        {
            Customer Book = GetById(id);
            context.Customers.Remove(Book);

            context.SaveChanges();
        }
    }
}
