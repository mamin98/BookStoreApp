using Book_Store.Models;

namespace Book_Store.Repository.Author_Repo
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();
        Author GetById(int id);
    }
}