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

        public DbSet<Book> Books { get; set; }
    }
}
