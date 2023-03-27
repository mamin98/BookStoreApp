using AutoMapper;
using Book_Store.DTOs.AuthorDTOs;
using Book_Store.DTOs.BookDTOs;
using Book_Store.Models;
using Book_Store.Repository.Author_Repo;
using Book_Store.Repository.Books_Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository author_Repo;
        private readonly IBookRepository book_Repo;
        private readonly IMapper mapper;

        public AuthorsController(IAuthorRepository author_repo, IMapper _mapper, IBookRepository book_Repo)
        {
            mapper = _mapper;
            author_Repo = author_repo;
            this.book_Repo = book_Repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Authors =
                author_Repo.GetAll()
                .Select(a => new AuthorDto
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Image = a.Image,
                    UploadImg = a.UploadImg,
                    Books = book_Repo.GetAll()
                    .Where(b => b.AuthorId == a.Id)
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
                    }).ToList()
                }).ToList();

            return Ok(Authors);
        }

        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult GetById(int id)
        {
            var author = author_Repo.GetByIdInclude(id);

            if (author == null)
            {
                return NotFound($"Author Not Found with id: {id}");
            }

            return Ok(author);
        }

        [HttpPost]
        public IActionResult PostAuthor([FromForm] CreateAuthorDto dto)
        {
            if (ModelState.IsValid)
            {
                var author = mapper.Map<Author>(dto);

                author_Repo.Insert(author);

                string actionLink = Url.Link("GetAuthor", new { id = author.Id });
                return Created(actionLink, author);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult PutAuthor([FromForm] CreateAuthorDto dto, int id)
        {
            var ExistingAuthor = author_Repo.GetById(id);

            if (ExistingAuthor != null)
            {
                if (ModelState.IsValid)
                {
                    var mappedAuthor = mapper.Map<Author>(dto);
                    mappedAuthor.Id = id;

                    author_Repo.Edit(mappedAuthor, id);

                    // Return with Modified Author
                    return Ok(mappedAuthor);
                }

                // if model is invalid
                return BadRequest(ModelState);
            }

            return NotFound($"There is No such an Author with id: {id}");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Author author = author_Repo.GetById(id);

            if (author == null)
            {
                return NotFound("Author not exist");
            }
            else
            {
                try
                {
                    author_Repo.Delete(id);

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
