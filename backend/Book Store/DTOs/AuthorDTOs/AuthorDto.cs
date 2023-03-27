using Book_Store.DTOs.BookDTOs;

namespace Book_Store.DTOs.AuthorDTOs
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string? Image { get; set; }

        public byte[]? UploadImg { get; set; }

        public List<HomeBookDto> Books { get; set; }
    }
}
