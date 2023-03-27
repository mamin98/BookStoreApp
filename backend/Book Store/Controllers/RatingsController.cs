using Book_Store.DTOs.BookDTOs;
using Book_Store.Repository.Books_Repo;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/books/{bookId:int}/ratings")]
public class RatingsController : ControllerBase
{
    private readonly IBookRepository _bookRepository;

    public RatingsController(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }


    [HttpPost]
    public async Task<IActionResult> AddRating(int bookId, RatingDto rating)
    {
        var result = await _bookRepository.AddRating(bookId, rating);

        return result ? CreatedAtAction(nameof(AddRating), new { bookId }, rating) : BadRequest();
    }
}
