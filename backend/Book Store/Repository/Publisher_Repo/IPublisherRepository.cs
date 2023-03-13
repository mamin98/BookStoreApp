using Book_Store.Models;

namespace Book_Store.Repository.Publisher_Repo
{
    public interface IPublisherRepository
    {
        List<Publisher> GetAll();
        Publisher GetById(int id);
        void Insert(Publisher New);
        void Edit(Publisher publisher, int id);
        void Delete(int id);
    }
}