using Book_Store.Models;

namespace Book_Store.Repository.Books_Repo
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BookStoreContext context;

        public BooksRepository(BookStoreContext _context)
        {
            context = _context;
        }

        // All Books
        public List<Books> GetAll()
        {
            return context.Books.ToList();
        }

        // Book by Id
        public Books GetById(int id)
        {
            return context.Books.FirstOrDefault(b => b.Id == id);
        }

        // Add new Book
        public void Insert(Books book)
        {

            context.Books.Add(book);
            context.SaveChanges();
        }

        // update Book details
        public void Edit(Books book, int id)
        {
            book = GetById(id);
            context.Update(book);

            context.SaveChanges();
        }


        // Delete Book 
        public void Delete(int id)
        {
            Books Book = GetById(id);
            context.Books.Remove(Book);

            context.SaveChanges();
        }
    }
}
