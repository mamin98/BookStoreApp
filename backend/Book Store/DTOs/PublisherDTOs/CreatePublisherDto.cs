using System.ComponentModel.DataAnnotations;

namespace Book_Store.DTOs.PublisherDTOs
{
    public class CreatePublisherDto
    {
        [Required]
        public string Name { get; set; }
    }
}
