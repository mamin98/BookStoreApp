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
        public DateTime? PublicationDate { get; set; }
        public byte[]? Image { get; set; }

        // Publisher
        public int PublisherId { get; set; }
        public string PublisherName { get; set; } = string.Empty;

        // Author 
        public int AuthorId { get; set; }
        public string AuthorName { get; set; } = string.Empty;

        // Type/Category
        public int TypeId { get; set; }
        public string BookType { get; set; } = string.Empty;
    }
}
