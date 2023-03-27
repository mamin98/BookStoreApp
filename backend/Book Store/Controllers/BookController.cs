using AutoMapper;

using Book_Store.DTOs.BookDTOs;
using Book_Store.DTOs.RatingsDtos;
using Book_Store.Models;
using Book_Store.Repository.Author_Repo;
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
        private readonly IAuthorRepository author_Repo;
        private readonly IMapper mapper;
        private List<string> allowedExtensions = new List<string> { ".jpg", "jpeg", ".png" };
        private long maxImgFileSize = 2097152;

        public BookController(IBookRepository book_repo, IMapper _mapper, IAuthorRepository author_Repo)
        {
            book_Repo = book_repo;
            mapper = _mapper;
            this.author_Repo = author_Repo;
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
                        Ratings = b.AverageRatings,
                        ImgFile = b.UploadImage
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
                    Ratings = b.AverageRatings,
                    ImgFile = b.UploadImage
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
            mappedBook.Reviews = book.Ratings
              .Select(r => new CreateNewRatingDto
              {
                  Stars = r.Stars,
                  Review = r.Review,
                  CustomerFirstName = r.Customer.FirstName,
                  CustomerLastName = r.Customer.LastName,
              }).ToList();

            return Ok(mappedBook);
        }

        [HttpPost]
        public IActionResult PostBook([FromForm] CreateBookDto dto)
        {
            if (ModelState.IsValid)
            {
                if (!allowedExtensions.Contains(Path.GetExtension(dto.ImgFile.FileName).ToLower()))
                    return BadRequest("Only jpg & png file extensions are allowed.");

                if (dto.ImgFile.Length > maxImgFileSize)
                    return BadRequest("Maximum allowed file size is 2 mb");

                var book = mapper.Map<Book>(dto);
                book.IsRecommended = true;

                // Upload Img File
                using var dataStream = new MemoryStream();

                dto.ImgFile.CopyTo(dataStream);
                book.UploadImage = dataStream.ToArray();

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
                    if (!allowedExtensions.Contains(Path.GetExtension(dto.ImgFile.FileName).ToLower()))
                        return BadRequest("Only jpg & png file extensions are allowed.");

                    if (dto.ImgFile.Length > maxImgFileSize)
                        return BadRequest("Maximum allowed file size is 2 mb");

                    using var dataStream = new MemoryStream();
                    dto.ImgFile.CopyTo(dataStream);

                    var MappedBook = mapper.Map<Book>(dto);
                    MappedBook.Id = id;
                    MappedBook.AuthorId = ExistingBook.AuthorId;
                    MappedBook.UploadImage = dataStream.ToArray();

                    book_Repo.Edit(MappedBook, id);

                    var author = author_Repo.GetById(MappedBook.AuthorId);

                    author.FirstName = dto.AuthorFirstName;
                    author.LastName = dto.AuthorLastName;

                    author_Repo.Edit(author, MappedBook.AuthorId);

                    MappedBook.Author = null;

                    // Return with the modified book
                    return Ok(MappedBook);
                }

                // if model is invalid
                return BadRequest(ModelState);
            }

            return NotFound($"There is No such a book with id: {id}");
        }

        [Authorize(Roles = "Administrator")]
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
