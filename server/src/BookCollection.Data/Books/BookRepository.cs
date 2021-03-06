﻿using BookCollection.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookCollection.Data.Books
{
    public class BookRepository
    {
        private readonly BookCollectionDbContext context;

        public BookRepository(BookCollectionDbContext context)
        {
            this.context = context;
        }

        public List<Book> Books
        {
            get
            {
                return new List<Book>(context.Books.Include(book => book.Author));
            }
        }

        public IEnumerable<Book> BooksByTitle()
        {
            return context
                .Books
                .OrderBy(book => book.Title)
                .Include(book => book.Author);
        }

        public IEnumerable<Book> BooksByAuthor()
        {
            return context
                .Books
                .OrderBy(book => book.Author)
                .Include(book => book.Author);
        }

        public Book WithTitle(string title)
        {
            return context.Books.Find(title);
        }

        public Book Add(Book book)
        {
            var addedBook = context.Add(book);
            context.SaveChanges();
            return addedBook.Entity;
        }

        /// <summary>
        /// Delete the book with the given title if it exists.
        /// </summary>
        /// <param name="book">The title of the book to delete.</param>
        /// <returns>The deleted book or null if no book was deleted.</returns>
        public Book Delete(string title)
        {
            var book = context.Books.Find(title);
            if (book != null)
            {
                var deletedBook = context.Remove(book).Entity;
                context.SaveChanges();
                return deletedBook;
            }
            else
            {
                return null;
            }
        }
    }
}
