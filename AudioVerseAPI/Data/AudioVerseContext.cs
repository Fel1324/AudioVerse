using System.Runtime.ConstrainedExecution;

using AudioVerseAPI.Models;

using Microsoft.EntityFrameworkCore;

namespace AudioVerseAPI.Data;

public class AudioVerseContext : DbContext
{
    public AudioVerseContext(DbContextOptions<AudioVerseContext> opts)
        : base(opts)
    {
        
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<AuthorBook> AuthorBooks { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Chapter> Chapters { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<GenreBook> GenreBooks { get; set; }
    public DbSet<User> Users { get; set; }
}
