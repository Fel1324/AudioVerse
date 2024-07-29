using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

namespace AudioVerseAPI.Profiles;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<CreateBookDto, Book>();
        CreateMap<UpdateBookDto, Book>();
        CreateMap<Book, UpdateBookDto>();
        CreateMap<Book, ReadBookDto>()
            .ForMember(bookDto => bookDto.AuthorBooks,
                    opt => opt.MapFrom(book => book.AuthorBooks)); ;
    }
}
