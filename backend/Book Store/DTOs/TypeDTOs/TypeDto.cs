using Book_Store.DTOs.BookDTOs;

namespace Book_Store.DTOs.TypeDTOs
{
    public class TypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<HomeBookDto> Books { get; set; } = new();
    }
}
