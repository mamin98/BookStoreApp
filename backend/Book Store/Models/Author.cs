using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string? Image { get; set; }

        public byte[]? UploadImg { get; set; }

        public List<Book> Book { get; set; }
    }
}
