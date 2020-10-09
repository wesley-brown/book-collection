using BookCollection.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookCollection.Data
{
    public sealed class BookCollectionDbContext : DbContext
    {
        public BookCollectionDbContext(
            DbContextOptions<BookCollectionDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var authors = new Author[] {
                    new Author("J. R. R. Tolkein"),
                    new Author("George R. R. Martin"),
                    new Author("J. K. Rowling")
                };
            modelBuilder.Entity<Author>().HasData(authors[0]);
            modelBuilder.Entity<Author>().HasData(authors[1]);
            modelBuilder.Entity<Author>().HasData(authors[2]);

            modelBuilder.Entity<Book>().HasData(new {
                Title = "The Hobbit",
                AuthorName = "J. R. R. Tolkein"
            });
            modelBuilder.Entity<Book>().HasData(new
            {
                Title = "The Lord of the Rings",
                AuthorName = "J. R. R. Tolkein"
            });
            modelBuilder.Entity<Book>().HasData(new
            {
                Title = "A Game of Thrones",
                AuthorName = "George R. R. Martin"
            });
            modelBuilder.Entity<Book>().HasData(new
            {
                Title = "A Clash of Kings",
                AuthorName = "George R. R. Martin"
            });
            modelBuilder.Entity<Book>().HasData(new
            {
                Title = "Harry Potter and the Philosopher's Stone",
                AuthorName = "J. K. Rowling"
            });
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
