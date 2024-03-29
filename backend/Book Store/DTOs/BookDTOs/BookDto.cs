﻿using System.ComponentModel.DataAnnotations;

namespace Book_Store.DTOs.BookDTOs
{
    public class BookDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(20, ErrorMessage = "Book title must be at most {1} characters long")]
        public string Title { get; set; } = ""; // string.Empty;

        [Required(ErrorMessage = "ISBN is required")]
        public string Isbn { get; set; } = "";

        [Required(ErrorMessage = "The price is required")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? PublicationDate { get; set; }
        public string? Image { get; set; }

        public IFormFile? ImgFile { get; set; }

        // Publisher        
        [Required(ErrorMessage = "Choose a Book Publisher")]
        public int PublisherId { get; set; }

        // Author 
        [Required(ErrorMessage = "Choose Author's First Name")]
        public string AuthorFirstName { get; set; }

        [Required(ErrorMessage = "Choose Author's Last Name")]
        public string AuthorLastName { get; set; }

        // Type/Category
        [Required(ErrorMessage = "Choose a Book type")]
        public int TypeId { get; set; }
    }
}
