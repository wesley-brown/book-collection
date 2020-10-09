using BookCollection.Data.Books;
using BookCollection.Domain;

namespace BookCollection.App.DeleteBook
{
    /// <summary>
    /// Deletes books from the collection.
    /// </summary>
    public sealed class BookDeleter
    {
        private BookRepository bookRepository;

        public BookDeleter(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        /// <summary>
        /// Delete the book with the given title.
        /// </summary>
        /// <param name="title">The title of the book to delete.</param>
        /// <returns>The deleted book or null of no book was deleted.</returns>
        public Book Delete(string title)
        {
            return bookRepository.Delete(title);
        }
    }
}
