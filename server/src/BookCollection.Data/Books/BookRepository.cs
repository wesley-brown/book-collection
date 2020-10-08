using BookCollection.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookCollection.Data.Books
{
    public class BookRepository
    {
        private readonly BookCollectionDbContext context;

        public BookRepository(BookCollectionDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Book> Books
        {
            get
            {
                return context.Books.Include(book => book.Author);
            }
        }
    }
}
