using AutoMapper;
using Book_Store.DTOs.PublisherDTOs;
using Book_Store.Models;
using Book_Store.Repository.Publisher_Repo;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly IPublisherRepository publisher_Repo;
        private readonly IMapper mapper;

        public PublishersController(IPublisherRepository publisher_Repo, IMapper mapper)
        {
            this.publisher_Repo = publisher_Repo;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var publishers = publisher_Repo.GetAll();

            return Ok(publishers);
        }

        [HttpGet("{id}", Name = "GetPublisher")]
        public IActionResult GetById(int id)
        {
            var publisher = publisher_Repo.GetById(id);

            if (publisher == null)
            {
                return NotFound($"Publisher Not Found with id: {id}");
            }

            return Ok(publisher);
        }

        [HttpPost]
        public IActionResult PostPublisher([FromForm] CreatePublisherDto dto)
        {
            if (ModelState.IsValid)
            {
                var publisher = mapper.Map<Publisher>(dto);

                publisher_Repo.Insert(publisher);

                string actionLink = Url.Link("GetPublisher", new { id = publisher.Id });
                return Created(actionLink, publisher);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult PutPublisher([FromForm] CreatePublisherDto dto, int id)
        {
            var ExistingPublisher = publisher_Repo.GetById(id);

            if (ExistingPublisher != null)
            {
                if (ModelState.IsValid)
                {
                    var mappedPublisher = mapper.Map<Publisher>(dto);
                    mappedPublisher.Id = id;

                    publisher_Repo.Edit(mappedPublisher, id);

                    // Return with Modified Publisher
                    return Ok(mappedPublisher);
                }

                // if model is invalid
                return BadRequest(ModelState);
            }

            return NotFound($"There is No such an Publisher with id: {id}");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Publisher publisher = publisher_Repo.GetById(id);

            if (publisher == null)
            {
                return NotFound("Publisher not exist");
            }
            else
            {
                try
                {
                    publisher_Repo.Delete(id);

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
