using AutoMapper;
using Book_Store.DTOs.AuthorDTOs;
using Book_Store.DTOs.BookDTOs;
using Book_Store.DTOs.PublisherDTOs;
using Book_Store.DTOs.TypeDTOs;
using Book_Store.Models;

namespace Book_Store.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Book, BookDetailsDto>();
            CreateMap<Book, HomeBookDto>();
            CreateMap<BookDto, Book>();
            CreateMap<CreateAuthorDto, Author>();
            CreateMap<CreateTypeDto, Types>();
            CreateMap<CreatePublisherDto, Publisher>();
        }
    }
}
