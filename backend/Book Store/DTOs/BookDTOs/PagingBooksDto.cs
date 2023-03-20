namespace Book_Store.DTOs.BookDTOs
{
    public class PagingBooksDto
    {
        public List<HomeBookDto> Books { get; set; } = new List<HomeBookDto>();

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}
