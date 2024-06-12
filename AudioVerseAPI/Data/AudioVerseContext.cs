using System.Runtime.ConstrainedExecution;

using AudioVerseAPI.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AudioVerseAPI.Data;

public class AudioVerseContext :IdentityDbContext<UserApp>
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
    public DbSet<UserApp> UserApps { get; set; }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<AuthorBook>()
            .HasOne(b => b.Author)
            .WithMany(a => a.AuthorBook)
            .HasForeignKey(b => b.AuthorId);

        builder.Entity<AuthorBook>()
            .HasOne(b => b.Book)
            .WithMany(a => a.AuthorBook)
            .HasForeignKey(b => b.BookId);

        builder.Entity<GenreBook>()
            .HasOne(b => b.Genre)
            .WithMany(a => a.GenreBook)
            .HasForeignKey(b => b.GenreId);

        builder.Entity<GenreBook>()
            .HasOne(b => b.Book)
            .WithMany(a => a.GenreBook)
            .HasForeignKey(b => b.BookId);

        builder.Entity<Favorite>()
            .HasOne(b => b.UserApp)
            .WithMany(a => a.Favorite)
            .HasForeignKey(b => b.UserAppId);

        builder.Entity<Favorite>()
            .HasOne(b => b.Book)
            .WithMany(a => a.Favorite)
            .HasForeignKey(b => b.BookId);
    }
}
