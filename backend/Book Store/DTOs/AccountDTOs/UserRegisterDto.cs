using System.ComponentModel.DataAnnotations;

namespace Book_Store.DTOs.AccountDTOs
{
    public class UserRegisterDto
    {
        [Required]
        [MinLength(3)]
        public string userName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [Compare("password")]
        public string confirmPassword { get; set; }
    }
}
