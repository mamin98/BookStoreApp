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

        public BookController(IBookRepository book_repo)
        {
            book_Repo = book_repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(book_Repo.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(book_Repo.GetById(id));
        }

        [HttpPost]
        public IActionResult PostBook(Book book)
        {
            if(ModelState.IsValid)
            {
                book_Repo.Insert(book);
                return Ok("inserted");
            }
            return BadRequest(ModelState);
        }
    }
}
