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
            return context.Author.FirstOrDefault(a => a.Id == id);
        }

        public void Insert(Author New)
        {
            context.Add(New);
            context.SaveChanges();
        }

        public void Edit(Author author, int id)
        {
            Author ExistingAuthor = GetById(id);

            ExistingAuthor = author;
            context.Update(ExistingAuthor);

            context.SaveChanges();
        }

        // Delete Author
        public void Delete(int id)
        {
            Author author = GetById(id);

            context.Remove(author);
            context.SaveChanges();
        }
    }
}
