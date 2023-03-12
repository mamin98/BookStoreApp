namespace Book_Store.Models
{
    public class Types
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Book> Books { get; set; } = null!;
    }
}
