using BookCollection.Data.Books;
using BookCollection.Domain;
using System.Collections.Generic;

namespace BookCollection.App.ViewBooks
{
    /// <summary>
    /// Creates various views of books.
    /// </summary>
    public sealed class BooksViewer
    {
        private readonly BookRepository bookRepository;

        public BooksViewer(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IEnumerable<Book> All
        {
            get
            {
                return bookRepository.Books;
            }
        }

        public IEnumerable<Book> AllBy(string column)
        {
            if (column == "title")
            {
                return bookRepository.BooksByTitle();
            }
            else if (column == "author")
            {
                return bookRepository.BooksByAuthor();
            }
            else
            {
                return All;
            }
        }
    }
}
