using Microsoft.EntityFrameworkCore;
using AudioVerseAPI.Models;


namespace AudioVerseAPI.Data;

public class AudioVerse : DbContext
{
    public AudioVerse(DbContextOptions<AudioVerse> opts)
        : base(opts)
    {
        
    }
    
    public DbSet<AudioVerse> AudioVerses { get; set; }
}
