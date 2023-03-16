namespace Book_Store.DTOs.BookDTOs;
public class CartItemDto
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice => Price * Quantity;
}
