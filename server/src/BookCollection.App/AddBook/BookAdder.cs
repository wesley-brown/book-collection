using BookCollection.Data.Authors;
using BookCollection.Data.Books;
using BookCollection.Domain;

namespace BookCollection.App.AddBook
{
    /// <summary>
    /// Creates book additions.
    /// </summary>
    public sealed class BookAdder
    {
        private readonly BookRepository bookRepository;
        private readonly AuthorRepository authorRepository;

        public BookAdder(
            BookRepository bookRepository,
            AuthorRepository authorRepository)
        {
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository;
        }

        public Book Add(string title, string name)
        {
            var author = authorRepository.AuthorWithName(name);
            var book = new Book(title, author);
            return bookRepository.Add(book);
        }
    }
}
