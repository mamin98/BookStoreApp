using AutoMapper;
using Book_Store.DTOs.BookDTOs;
using Book_Store.DTOs.TypeDTOs;
using Book_Store.Models;
using Book_Store.Repository.Books_Repo;
using Book_Store.Repository.Types_Repo;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesController : ControllerBase
    {
        private readonly ITypesRepository type_Repo;
        private readonly IBookRepository book_Repo;
        private readonly IMapper mapper;

        public TypesController(ITypesRepository type_Repo, IMapper mapper, IBookRepository book_Repo)
        {
            this.type_Repo = type_Repo;
            this.mapper = mapper;
            this.book_Repo = book_Repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Types =
                type_Repo.GetAll()
                .Select(t => new TypeDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    Books = book_Repo.GetAll()
                    .Where(b => b.TypeId == t.Id)
                    .Select(b => new HomeBookDto 
                    {
                        AuthorName = b.Author.FirstName + " " + b.Author.LastName,
                        Category = b.BookType.Name,
                        PublisherName = b.Publisher.Name,
                        ID = b.Id,
                        Image = b.Image,
                        Price = b.Price,
                        Title = b.Title,
                        Quantity = b.QuantityInStock
                    }).ToList()
                }).ToList();

            return Ok(Types);
        }

        [HttpGet("{id}", Name = "GetType")]
        public IActionResult GetById(int id)
        {
            var type =
                type_Repo.GetByIdInclude(id);

            if (type == null)
            {
                return NotFound($"Type Not Found with id: {id}");
            }

            return Ok(type);
        }

        [HttpPost]
        public IActionResult PostType([FromForm] CreateTypeDto dto)
        {
            if (ModelState.IsValid)
            {
                var type = mapper.Map<Types>(dto);

                type_Repo.Insert(type);

                string actionLink = Url.Link("GetType", new { id = type.Id });
                return Created(actionLink, type);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult PutType([FromForm] CreateTypeDto dto, int id)
        {
            var ExistingType = type_Repo.GetById(id);

            if (ExistingType != null)
            {
                if (ModelState.IsValid)
                {
                    var mappedType = mapper.Map<Types>(dto);
                    mappedType.Id = id;

                    type_Repo.Edit(mappedType, id);

                    // return with modified type
                    return Ok(mappedType);
                }

                // if model is invalid
                return BadRequest(ModelState);
            }

            return NotFound($"There is No such an Type with id: {id}");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Types type = type_Repo.GetById(id);

            if (type == null)
            {
                return NotFound("Type not exist");
            }
            else
            {
                try
                {
                    type_Repo.Delete(id);

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
