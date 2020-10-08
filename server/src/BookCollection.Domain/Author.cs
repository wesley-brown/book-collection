namespace BookCollection.Domain
{
    /// <summary>
    /// A person who writes books.
    /// </summary>
    public sealed class Author
    {
        /// <summary>
        /// The name of this Author.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Create an author with a given name.
        /// </summary>
        /// <param name="name">The name of the author.</param>
        public Author(string name)
        {
            Name = name;
        }

        public override int GetHashCode()
        {
            int hash = 7;
            hash = 31 * hash + Name.GetHashCode();
            return hash;
        }
    }
}
