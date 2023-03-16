﻿using Book_Store.Models;

namespace Book_Store.DTOs.BookDTOs
{
    public class HomeBookDto
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string? Image { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string AuthorName { get; set; }

        public string Category { get; set; }
    }
}
