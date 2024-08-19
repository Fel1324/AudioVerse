using System.Reflection.Emit;
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
    public DbSet<Genre> Genres { get; set; }
    public DbSet<GenreBook> GenreBooks { get; set; }
    public DbSet<UserApp> UserApps { get; set; }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<AuthorBook>()
            .HasKey(authorBook => new { authorBook.BookId, authorBook.AuthorId });

        builder.Entity<AuthorBook>()
            .HasOne(authorBook => authorBook.Author)
            .WithMany(author => author.AuthorBooks)
            .HasForeignKey(authorBook => authorBook.AuthorId);

        builder.Entity<AuthorBook>()
            .HasOne(authorBook => authorBook.Book)
            .WithMany(book => book.AuthorBooks)
            .HasForeignKey(authorBook => authorBook.BookId);

        /*-------------------------------------------------*/

        builder.Entity<GenreBook>()
            .HasKey(genreBook => new { genreBook.BookId, genreBook.GenreId });

        builder.Entity<GenreBook>()
            .HasOne(genreBook => genreBook.Genre)
            .WithMany(genre => genre.GenreBooks)
            .HasForeignKey(genreBook => genreBook.GenreId);

        builder.Entity<GenreBook>()
            .HasOne(genreBook => genreBook.Book)
            .WithMany(book => book.GenreBooks)
            .HasForeignKey(genreBook => genreBook.BookId);

        /*-----------------------------------------------*/

        builder.Entity<Chapter>()
        .HasKey(c => c.Id); // Certifica-se de que `Id` é a chave primária

        builder.Entity<Chapter>()
            .Property(c => c.Id)
            .ValueGeneratedOnAdd(); // Garantir que o Id é gerado automaticamente
    }
}
