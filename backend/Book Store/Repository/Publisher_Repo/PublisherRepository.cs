using Book_Store.Models;

namespace Book_Store.Repository.Publisher_Repo
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly BookStoreContext context;

        public PublisherRepository(BookStoreContext _context)
        {
            context = _context;
        }

        // All Publishers
        public List<Publisher> GetAll()
        {
            return context.Publisher.ToList();
        }

        // Publisher by Id
        public Publisher GetById(int id)
        {
            return context.Publisher.FirstOrDefault(b => b.Id == id);
        }
    }
}
