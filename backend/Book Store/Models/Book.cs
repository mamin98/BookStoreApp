using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
        public DateOnly? PublicationDate { get; set; }
        
        // upload image, when create add book
        public byte[]? UploadImage { get; set; }
        
        // test image
        public string? Image { get; set; }

        // select all books or specific books
        public bool IsRecommended { get; set; } = false;

        // Publisher
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        // Author 
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        // Type/Category
        [ForeignKey("BookType")]
        public int TypeId { get; set; }
        public Types BookType { get; set; }

        public List<OrderItem> Items { get; set; }

    }
}
