using System.ComponentModel.DataAnnotations;

namespace Book_Store.DTOs.AuthorDTOs
{
    public class CreateAuthorDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Author's First Name")]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "Please Enter Author's Last Name")]
        public string LastName { get; set; } = "";

        public byte[]? UploadImg { get; set; }
    }
}
