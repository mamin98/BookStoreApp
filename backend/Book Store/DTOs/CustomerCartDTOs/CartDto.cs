namespace Book_Store.DTOs.BookDTOs;

public class CartDto
{
    public int CustomerId { get; set; }
    public List<CartItemDto> CartItems { get; set; } = null!;
}