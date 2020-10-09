using BookCollection.Data.Authors;
using BookCollection.Data.Books;
using BookCollection.Domain;

namespace BookCollection.App.EditBook
{
    /// <summary>
    /// Edits books by changing their authors.
    /// </summary>
    public class BookEditor
    {
        private BookRepository bookRepository;
        private AuthorRepository authorRepository;

        public BookEditor(
            BookRepository bookRepository,
            AuthorRepository authorRepository)
        {
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository;
        }

        public Book EditBookWithTitle(string title, string newAuthor)
        {
            var book = bookRepository.WithTitle(title);
            if (book != null)
            {
                // Remove existing book
                bookRepository.Delete(book.Title);
                // Create new one with same title and different author
                var author = authorRepository.AuthorWithName(newAuthor);
                var newBook = new Book(title, author);
                bookRepository.Add(newBook);
                return newBook;
            }
            else
            {
                return null;
            }
        }
    }
}
