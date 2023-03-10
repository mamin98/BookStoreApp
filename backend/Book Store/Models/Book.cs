using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = ""; // string.Empty;
        public string Isbn { get; set; } = "";
        public decimal Price { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string? Image { get; set; }
        
        // Publisher
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; } = new Publisher();

        // Author 
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; } = new Author();

        // Type/Category
        [ForeignKey("BookType")]
        public int TypeId { get; set; }
        public Types BookType { get; set; } = new Types();

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    }
}
