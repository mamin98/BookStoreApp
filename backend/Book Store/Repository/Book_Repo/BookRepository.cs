using Book_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Store.Repository.Books_Repo
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext context;

        public BookRepository(BookStoreContext _context)
        {
            context = _context;
        }

        // All Books
        public List<Book> GetAll()
        {
            return context.Books.ToList();
        }

        // Book by Id
        public Book GetById(int id)
        {
            return context.Books.Include(b => b.Author)
                .Include(b => b.BookType)
                .Include(b => b.Publisher)
                .FirstOrDefault(b => b.Id == id);
        }

        // Add new Book
        public void Insert(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }

        // update Book details
        public void Edit(Book book, int id)
        {
            Book ExistingBook = GetById(id);

            ExistingBook = book;
            context.Update(ExistingBook);

            context.SaveChanges();
        }


        // Delete Book 
        public void Delete(int id)
        {
            Book Book = GetById(id);
            context.Books.Remove(Book);

            context.SaveChanges();
        }
    }
}
