using AudioVerseAPI.Data.Dtos;
using AudioVerseAPI.Models;

using AutoMapper;

namespace AudioVerseAPI.Profiles;

public class ChapterProfile : Profile
{
    public ChapterProfile()
    {
        CreateMap<CreateChapterDto, Chapter>();
        CreateMap<Chapter, ReadChapterDto>();
    }
}
