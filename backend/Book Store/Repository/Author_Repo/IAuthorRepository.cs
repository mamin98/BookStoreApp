using Book_Store.DTOs.AuthorDTOs;
using Book_Store.Models;

namespace Book_Store.Repository.Author_Repo
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();
        Author GetById(int id);
        void Insert(Author author);
        void Edit(Author author, int id);
        void Delete(int id);
        AuthorDto GetByIdInclude(int id);
    }
}