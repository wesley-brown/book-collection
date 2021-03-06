﻿using BookCollection.App.ViewBooks;
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

        [HttpGet]
        public IActionResult GetAllBooks(string sort_by)
        {
            return Ok(booksViewer.AllBy(sort_by));
        }
    }
}
