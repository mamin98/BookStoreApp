using Book_Store.DTOs.AuthorDTOs;
using Book_Store.DTOs.BookDTOs;
using Book_Store.Models;
using Book_Store.Repository.Books_Repo;
using Microsoft.EntityFrameworkCore;

namespace Book_Store.Repository.Author_Repo
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BookStoreContext context;
        private readonly IBookRepository book_Repo;

        public AuthorRepository(BookStoreContext _context, IBookRepository book_Repo)
        {
            context = _context;
            this.book_Repo = book_Repo;
        }

        // All Authors
        public List<Author> GetAll()
        {
            return context.Author.Include(a => a.Book).ToList();
        }

        // Author by Id
        public Author GetById(int id)
        {
            return context.Author.AsNoTracking().FirstOrDefault(a => a.Id == id);
        }

        public AuthorDto GetByIdInclude(int id)
        {
            var books =
                book_Repo.GetAll()
                .Where(b => b.AuthorId == id)
                .Select(b => new HomeBookDto
                {
                    AuthorName = b.Author.FirstName + " " + b.Author.LastName,
                    Category = b.BookType.Name,
                    PublisherName = b.Publisher.Name,
                    ID = b.Id,
                    Image = b.Image,
                    Price = b.Price,
                    Title = b.Title,
                    Quantity = b.QuantityInStock,
                    Ratings = b.AverageRatings,
                    ImgFile = b.UploadImage
                }).ToList();

            var author =
                context.Author
                .Include(a => a.Book)
                .Where(a => a.Id == id)
                .Select(a => new AuthorDto
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Image = a.Image,
                    UploadImg = a.UploadImg,
                    Books = books
                })
                .FirstOrDefault();

            return author;
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
