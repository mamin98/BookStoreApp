using AutoMapper;

using Book_Store.DTOs.BookDTOs;
using Book_Store.Models;
using Book_Store.Repository.Books_Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository book_Repo;
        private readonly IMapper mapper;

        public BookController(IBookRepository book_repo, IMapper _mapper)
        {
            book_Repo = book_repo;
            mapper = _mapper;
        }

        [HttpGet("books", Name = "HomePage")]
        public IActionResult GetAll([FromQuery] int? page)
        {
            if (page != null)
            {
                var OnePageBooks = 8f;
                var PagesCount = Math.Ceiling(book_Repo.GetAll().Count / OnePageBooks);

                if (page > PagesCount)
                    return NotFound();

                var books =
                    book_Repo.GetAll()
                    .Skip((int)((page - 1) * (int)OnePageBooks))
                    .Take((int)OnePageBooks)
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
                        Ratings = b.AverageRatings
                    })
                    .ToList();

                var HomeBooks = new PagingBooksDto
                {
                    Books = books,
                    CurrentPage = (int)page,
                    TotalPages = (int)PagesCount
                };

                return Ok(HomeBooks);
            }

            var allBooks =
                book_Repo.GetAll()
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
                    Ratings = b.AverageRatings
                }).ToList();

            return Ok(allBooks);
        }

        [HttpGet("{id:int}", Name = "BookRoute")]
        public IActionResult GetById(int id)
        {
            var book = book_Repo.GetByIdInclude(id);

            if (book == null)
            {
                return NotFound($"Book Not Found with id: {id}");
            }

            var mappedBook = mapper.Map<BookDetailsDto>(book);

            mappedBook.AuthorName = book.Author.FirstName + " " + book.Author.LastName;
            mappedBook.BookType = book.BookType.Name;
            mappedBook.PublisherName = book.Publisher.Name;

            return Ok(mappedBook);
        }

        [HttpPost]
        public IActionResult PostBook([FromForm] BookDto dto)
        {
            if (ModelState.IsValid)
            {
                var book = mapper.Map<Book>(dto);
                book.IsRecommended = true;
                book_Repo.Insert(book);

                string actionLink = Url.Link("BookRoute", new { id = book.Id });
                return Created(actionLink, book);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult PutBook(int id, [FromBody] BookDto dto)
        {
            var ExistingBook = book_Repo.GetById(id);

            if (ExistingBook != null)
            {
                if (ModelState.IsValid)
                {
                    var MappedBook = mapper.Map<Book>(dto);
                    MappedBook.Id = id;
                    //ExistingBook = MappedBook;
                    book_Repo.Edit(MappedBook, id);

                    // Return with the modified book
                    return Ok(MappedBook);
                }

                // if model is invalid
                return BadRequest(ModelState);
            }

            return NotFound($"There is No such a book with id: {id}");
        }

        [Authorize(Roles ="Administrator")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Book book = book_Repo.GetById(id);

            if (book == null)
            {
                return NotFound("Book not exist");
            }
            else
            {
                try
                {
                    book_Repo.Delete(id);

                    // no content, data deleted
                    return StatusCode(StatusCodes.Status204NoContent);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
