using BookCollection.App.DeleteBook;
using Microsoft.AspNetCore.Mvc;

namespace BookCollection.DeleteBook
{
    /// <summary>
    /// A REST endpoint controller for deleting books from the collection.
    /// </summary>
    [ApiController]
    [Route("/api/books")]
    public sealed class DeleteBookController : ControllerBase
    {
        private BookDeleter bookDeleter;

        /// <summary>
        /// Create a new delete book REST endpoint controller.
        /// </summary>
        /// <param name="bookDeleter"></param>
        public DeleteBookController(BookDeleter bookDeleter)
        {
            this.bookDeleter = bookDeleter;
        }

        /// <summary>
        /// Delete the book with the given title if it exists.
        /// </summary>
        /// <param name="title">The title of the book to delete.</param>
        /// <returns>The deleted book if it existed.</returns>
        [HttpDelete("{title}")]
        public IActionResult DeleteBook(string title)
        {
            var deletedBook = bookDeleter.Delete(title);
            if (deletedBook != null)
            {
                return Ok(bookDeleter.Delete(title));
            }
            else
            {
                return Ok("Book with title '" + title + "' not found");
            }
        }
    }
}
