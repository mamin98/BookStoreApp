namespace Book_Store.DTOs.BookDTOs
{
    public class HomeBookDto
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public byte[]? Image { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
