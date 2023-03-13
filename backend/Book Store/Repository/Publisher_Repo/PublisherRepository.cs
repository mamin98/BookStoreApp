using Book_Store.Models;
using Microsoft.EntityFrameworkCore;

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
            return context.Publisher.AsNoTracking().FirstOrDefault(b => b.Id == id);
        }

        // Add New Publisher
        public void Insert(Publisher New)
        {
            context.Add(New);
            context.SaveChanges();
        }

        // Edit Existing Publisher
        public void Edit(Publisher publisher, int id)
        {
            Publisher ExistingPublisher = GetById(id);

            ExistingPublisher = publisher;
            context.Update(ExistingPublisher);

            context.SaveChanges();
        }

        // Delete Publisher
        public void Delete(int id)
        {
            Publisher publisher = GetById(id);

            context.Remove(publisher);
            context.SaveChanges();
        }
    }
}
