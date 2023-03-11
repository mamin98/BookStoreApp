using AutoMapper;
using Book_Store.DTOs.BookDTOs;
using Book_Store.Models;
using Book_Store.Repository.Books_Repo;
using Microsoft.AspNetCore.Http;
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

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(book_Repo.GetAll());
        }

        [HttpGet("{id}", Name ="BookRoute")]
        public IActionResult GetById(int id)
        {
            var book = book_Repo.GetById(id);

            if (book == null)
            {
                return NotFound($"Book Not Found with id: {id}");
            }

            var mappedBook = mapper.Map<BookDetailsDto>(book);

            return Ok(mappedBook);
        }

        [HttpPost]
        public IActionResult PostBook(Book book)
        {
            if(ModelState.IsValid)
            {
                book_Repo.Insert(book);

                string actionLink = Url.Link("BookRoute", new { id = book.Id });
                return Created(actionLink, book); 
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult PutBook(Book book, int id) 
        {
            var ExistingBook = book_Repo.GetById(id);

            if (ExistingBook != null)
            {
                if (ModelState.IsValid)
                {
                    book_Repo.Edit(book, id);

                    // no content, data updated
                    return StatusCode(StatusCodes.Status204NoContent);
                }

                return BadRequest(ModelState);
            }

            // if model is invalid
            return NotFound($"There is No such a book with id: {id}");
        }

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
                }catch(Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
