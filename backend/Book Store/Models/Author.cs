using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public List<Books> Book { get; set; } = new List<Books>();
    }
}
