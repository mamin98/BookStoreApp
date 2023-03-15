using Book_Store.Models;

namespace Book_Store.DTOs.BookDTOs
{
    public class PagingBooksDto
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}
