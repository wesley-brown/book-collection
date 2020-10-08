using BookCollection.App.ViewBooks;
using Microsoft.AspNetCore.Mvc;

namespace BookCollection.ViewAllBooks
{
    [ApiController]
    [Route("/api/books")]
    public sealed class ViewAllBooksController : ControllerBase
    {
        private readonly BooksViewer booksViewer;

        public ViewAllBooksController(BooksViewer booksViewer)
        {
            this.booksViewer = booksViewer;
        }

        public IActionResult GetAllBooks()
        {
            return Ok(booksViewer.All);
        }
    }
}
