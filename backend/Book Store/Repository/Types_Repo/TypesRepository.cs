using Book_Store.DTOs.BookDTOs;
using Book_Store.DTOs.TypeDTOs;
using Book_Store.Models;
using Book_Store.Repository.Books_Repo;
using Microsoft.EntityFrameworkCore;

namespace Book_Store.Repository.Types_Repo
{
    public class TypesRepository : ITypesRepository
    {
        private readonly BookStoreContext context;
        private readonly IBookRepository book_Repo;

        public TypesRepository(BookStoreContext _context, IBookRepository bookRepo)
        {
            context = _context;
            this.book_Repo = bookRepo;
        }

       
        // All Types
        public List<Types> GetAll()
        {
            return context.Types
                .Include(t => t.Books)
                .ToList();
        }

        // Type by Id
        public Types GetById(int id)
        {
            return context.Types.AsNoTracking().FirstOrDefault(t => t.Id == id);
        }

        public TypeDto GetByIdInclude(int id)
        {
            var typeBooks = book_Repo.GetAll()
                    .Where(b => b.TypeId == id)
                    .Select(b => new HomeBookDto
                    {
                        AuthorName = b.Author.FirstName + " " + b.Author.LastName,
                        //Category = b.BookType.Name,
                        PublisherName = b.Publisher.Name,
                        ID = b.Id,
                        Image = b.Image,
                        Price = b.Price,
                        Title = b.Title,
                        Quantity = b.QuantityInStock
                    }).ToList();

            var type = context.Types.Include(t => t.Books)
                .AsNoTracking()
                //.Where(t => t.Id == id)
                .Select(t => new TypeDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    Books = typeBooks
                }).FirstOrDefault(t => t.Id == id);

            return type;
        }

        // Add new Type
        public void Insert(Types type)
        {
            context.Types.Add(type);
            context.SaveChanges();
        }

        // update Type details
        public void Edit(Types type, int id)
        {
            Types ExistingType = GetById(id);

            ExistingType = type;
            context.Update(ExistingType);

            context.SaveChanges();
        }


        // Delete Type
        public void Delete(int id)
        {
            Types type = GetById(id);
            context.Types.Remove(type);

            context.SaveChanges();
        }
    }
}
