namespace BookCollection.AddBook
{
    /// <summary>
    /// The body of an HTTP POST request to add a book to a collection.
    /// </summary>
    public sealed class AddBookRequest
    {
        /// <summary>
        /// The title of the book to add.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The author of the book to add.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Create a default add book request.
        /// </summary>
        /// <remarks>
        /// The request deserializer requires this to be here.
        /// </remarks>
        public AddBookRequest()
        {
        }

        /// <summary>
        /// Create a new add book request for a book with the given title and
        /// author.
        /// </summary>
        /// <param name="title">The title of the book to add.</param>
        /// <param name="author">The author of the book to add.</param>
        public AddBookRequest(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
