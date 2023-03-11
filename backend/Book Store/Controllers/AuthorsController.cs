using AutoMapper;
using Book_Store.DTOs.AuthorDTOs;
using Book_Store.Models;
using Book_Store.Repository.Author_Repo;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository author_Repo;
        private readonly IMapper mapper;

        public AuthorsController(IAuthorRepository author_repo, IMapper _mapper)
        {
            mapper = _mapper;
            author_Repo = author_repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Authors = author_Repo.GetAll();

            return Ok(Authors);
        }

        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult GetById(int id)
        {
            var author = author_Repo.GetById(id);

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
        public IActionResult PutAuthor([FromForm] Author author, int id)
        {
            var ExistingAuthor = author_Repo.GetById(id);

            if (ExistingAuthor != null)
            {
                if (ModelState.IsValid)
                {
                    author_Repo.Edit(author, id);

                    // no content, data updated
                    return StatusCode(StatusCodes.Status204NoContent);
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
