using System.ComponentModel.DataAnnotations;

namespace Book_Store.DTOs.AccountDTOs
{
    public class UserLoginDto
    {
        [Required]
        public string userName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
