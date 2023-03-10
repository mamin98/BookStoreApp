using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Books> Book { get; set; } = new List<Books>();
    }
}
