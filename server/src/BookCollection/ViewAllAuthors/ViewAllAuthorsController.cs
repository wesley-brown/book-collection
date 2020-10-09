using BookCollection.App.ViewAuthors;
using Microsoft.AspNetCore.Mvc;

namespace BookCollection.ViewAllAuthors
{
    [ApiController]
    [Route("/api/authors")]
    public sealed class ViewAllAuthorsController : ControllerBase
    {
        private AuthorsViewer authorsViewer;

        public ViewAllAuthorsController(AuthorsViewer authorsViewer)
        {
            this.authorsViewer = authorsViewer;
        }

        public IActionResult GetAllAuthors()
        {
            return Ok(authorsViewer.GetAllAuthors());
        }
    }
}
