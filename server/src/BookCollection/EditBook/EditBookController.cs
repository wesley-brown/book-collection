using BookCollection.App.EditBook;
using BookCollection.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BookCollection.EditBook
{
    /// <summary>
    /// A REST endpoint controller for editing books.
    /// </summary>
    [ApiController]
    [Route("/api/books")]
    public sealed class EditBookController : ControllerBase
    {
        private readonly BookEditor bookEditor;

        public EditBookController(BookEditor bookEditor)
        {
            this.bookEditor = bookEditor;
        }

        [HttpPut("{title}")]
        public IActionResult PutBook(string title, EditBookRequest request)
        {
            var editedBook = bookEditor.EditBookWithTitle(title, request.Author);
            return Ok(editedBook);
        }
    }
}
