using System.ComponentModel.DataAnnotations;

namespace Book_Store.DTOs.TypeDTOs
{
    public class CreateTypeDto
    {
        [Required(ErrorMessage = "Please Enter Type Name")]
        public string Name { get; set; }
    }
}
