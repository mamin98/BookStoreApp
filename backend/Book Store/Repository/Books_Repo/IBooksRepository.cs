using Book_Store.Models;

namespace Book_Store.Repository.Books_Repo
{
    public interface IBooksRepository
    {
        void Delete(int id);
        void Edit(Books book, int id);
        List<Books> GetAll();
        Books GetById(int id);
        void Insert(Books book);
    }
}