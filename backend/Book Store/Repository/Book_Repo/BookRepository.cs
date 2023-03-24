using Book_Store.DTOs.BookDTOs;
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
            return context.Books
                .Include(b => b.Author)
                .Include(b => b.BookType)
                .Include(b => b.Publisher)
                .ToList();
        }

        public Book GetByIdInclude(int id)
        {
            return context.Books.Include(b => b.Author)
                .Include(b => b.BookType)
                .Include(b => b.Publisher)
                .FirstOrDefault(b => b.Id == id);
        }

        // Book by Id
        public Book GetById(int id)
        {
            return context.Books.AsNoTracking().FirstOrDefault(b => b.Id == id);
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

        // Add Rating
        public async Task<bool> AddRating(int bookId, RatingDto ratingDto)
        {
            try
            {
                var book = GetById(bookId);

                // to be replace by real user id
                var mockUserId = 1;
                var mockedCustomer = context.Customers.FirstOrDefaultAsync(c => c.ID == mockUserId);

                var rating = new Rating
                {
                    BookId = bookId,
                    Customer = mockedCustomer.Result,
                    Stars = ratingDto.Stars,
                    Review = ratingDto.Review,
                };

                // update database ratings records
                await context.Rating.AddAsync(rating);

                // update the product's average rating
                var ratings = await context.Rating.Where(r => r.BookId == bookId).ToListAsync();

                book.AverageRatings = (float)ratings.Average(r => r.Stars);

                // ensure ef core tracking products new value
                context.Books.Update(book);

                // update database
                await context.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
