using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Book> Book { get; set; } = new List<Book>();
    }
}
