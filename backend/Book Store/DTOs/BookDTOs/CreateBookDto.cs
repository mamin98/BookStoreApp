using System.ComponentModel.DataAnnotations;

namespace Book_Store.DTOs.BookDTOs
{
    public class CreateBookDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, ErrorMessage = "Book title must be at most {1} characters long")]
        public string Title { get; set; } = ""; // string.Empty;

        [Required(ErrorMessage = "ISBN is required")]
        public string Isbn { get; set; } = "";

        [Required(ErrorMessage = "The price is required")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? PublicationDate { get; set; }
        public string? Image { get; set; }

        public IFormFile? ImgFile { get; set; }

        // Publisher        
        [Required(ErrorMessage = "Choose the Publisher of the book")]
        public int PublisherId { get; set; }

        // Author 
        [Required(ErrorMessage = "Choose the Author of the book")]
        public int AuthorId { get; set; }

        // Type/Category
        [Required(ErrorMessage = "Choose the Category of the book")]
        public int TypeId { get; set; }
    }
}
