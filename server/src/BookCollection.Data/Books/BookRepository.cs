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

        public List<Book> Books
        {
            get
            {
                return new List<Book>(context.Books.Include(book => book.Author));
            }
        }

        public Book Add(Book book)
        {
            var addedBook = context.Add(book);
            context.SaveChanges();
            return addedBook.Entity;
        }

        /// <summary>
        /// Delete the book with the given title if it exists.
        /// </summary>
        /// <param name="book">The title of the book to delete.</param>
        /// <returns>The deleted book or null if no book was deleted.</returns>
        public Book Delete(string title)
        {
            var book = context.Books.Find(title);
            if (book != null)
            {
                var deletedBook = context.Remove(book).Entity;
                context.SaveChanges();
                return deletedBook;
            }
            else
            {
                return null;
            }
        }
    }
}
