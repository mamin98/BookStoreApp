using Book_Store.Models;

namespace Book_Store.Repository.Customers_Repo
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly BookStoreContext context;

        public CustomersRepository(BookStoreContext _context)
        {
            context = _context;
        }

        // All Customers
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        // Customer by Id
        public Customers GetById(int id)
        {
            return context.Customers.FirstOrDefault(b => b.ID == id);
        }


        // Delete Customer 
        public void Delete(int id)
        {
            Customers Book = GetById(id);
            context.Customers.Remove(Book);

            context.SaveChanges();
        }
    }
}
