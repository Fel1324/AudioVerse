using Microsoft.EntityFrameworkCore;
using AudioVerseAPI.Models;


namespace AudioVerseAPI.Data;

public class AudioVerseContext : DbContext
{
    public AudioVerseContext(DbContextOptions<AudioVerseContext> opts)
        : base(opts)
    {
        
    }
    #region AudioVerse deu erro, então coloquei "AudioVerseContext", que aparentemente funcionou.
    public DbSet<AudioVerseContext> AudioVerses { get; set; }
    #endregion
}
