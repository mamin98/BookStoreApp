namespace Book_Store.DTOs.RatingsDtos;
public class CreateNewRatingDto
{
    public int Stars { get; set; }
    public string CustomerFirstName { get; set; } = null!;
    public string CustomerLastName { get; set; } = null!;
    public string? Review { get; set; } = null!;
}