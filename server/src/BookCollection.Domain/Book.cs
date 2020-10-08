﻿namespace BookCollection.Domain
{
    /// <summary>
    /// A book.
    /// </summary>
    public sealed class Book
    {
        /// <summary>
        /// The title of this book.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// The author of this book.
        /// </summary>
        public Author Author { get; }

        /// <summary>
        /// Create a book with a given title and author.
        /// </summary>
        /// <param name="title">The title of the book.</param>
        /// <param name="author">The author of the book.</param>
        public Book(string title, Author author)
        {
            Title = title;
            Author = author;
        }

        public override int GetHashCode()
        {
            int hash = 7;
            hash = 31 * hash + Title.GetHashCode();
            hash = 31 * hash + Author.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Book otherBook = (Book)obj;
                return Title.Equals(otherBook.Title)
                    && Author.Equals(otherBook.Author);
            }
        }

        public override string ToString()
        {
            return "<Book: Title=" + Title + ", Author=" + Author + ">";
        }
    }
}
