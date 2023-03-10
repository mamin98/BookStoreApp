using Book_Store.Models;

namespace Book_Store.Repository.Author_Repo
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BookStoreContext context;

        public AuthorRepository(BookStoreContext _context)
        {
            context = _context;
        }

        // All Authors
        public List<Author> GetAll()
        {
            return context.Author.ToList();
        }

        // Author by Id
        public Author GetById(int id)
        {
            return context.Author.FirstOrDefault(b => b.Id == id);
        }
    }
}
