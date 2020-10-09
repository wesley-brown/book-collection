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

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
