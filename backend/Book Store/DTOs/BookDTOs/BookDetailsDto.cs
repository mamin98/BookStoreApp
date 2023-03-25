using Book_Store.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.DTOs.BookDTOs
{
    public class BookDetailsDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = ""; // string.Empty;
        public string Isbn { get; set; } = "";
        public decimal Price { get; set; }
        public DateOnly? PublicationDate { get; set; }
        public string? Image { get; set; }
        public byte[]? UploadImage { get; set; }

        // Publisher
        public string PublisherName { get; set; } = string.Empty;

        // Author 
        public string AuthorName { get; set; } = string.Empty;

        // Type/Category
        public string BookType { get; set; } = string.Empty;
    }
}
