namespace BookCollection.EditBook
{
    /// <summary>
    /// An HTTP PUT request to edit a book resource.
    /// </summary>
    public sealed class EditBookRequest
    {
        public string Author { get; set; }

        public EditBookRequest()
        {
        }
    }
}
