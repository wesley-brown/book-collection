using BookCollection.App.AddBook;
using BookCollection.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BookCollection.AddBook
{
    /// <summary>
    /// A REST endpoint controller that handles the add book use case.
    /// </summary>
    [ApiController]
    [Route("/api/books")]
    public sealed class AddBookController : ControllerBase
    {
        private readonly BookAdder bookAdder;

        /// <summary>
        /// Create a new add book controller.
        /// </summary>
        /// <param name="bookAdder">The book adder to use.</param>
        public AddBookController(BookAdder bookAdder)
        {
            this.bookAdder = bookAdder;
        }

        /// <summary>
        /// Handle an HTTP POST request to add a new book to the collection.
        /// </summary>
        /// <param name="request">The add book request.</param>
        /// <returns>
        /// The result of adding a book with the given information in the add
        /// book request.
        /// </returns>
        [HttpPost]
        public IActionResult PostBook(AddBookRequest request)
        {
            var author = new Author(request.Author);
            var book = new Book(request.Title, author);
            return CreatedAtAction(null, bookAdder.Add(book));
        }
    }
}
