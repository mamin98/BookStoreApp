using Book_Store.Models;
using Book_Store.Repository.Books_Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository book_Repo;

        public BooksController(IBooksRepository book_repo)
        {
            book_Repo = book_repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(book_Repo.GetAll());
        }

        //[HttpGet]
        //public IActionResult GetById(int id)
        //{
        //    return Ok(book_Repo.GetById(id));
        //}

        [HttpPost]
        public IActionResult PostBook(Books book)
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
