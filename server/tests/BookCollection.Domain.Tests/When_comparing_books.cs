using Xunit;

namespace BookCollection.Domain.Tests
{
    public sealed class When_comparing_books
    {
        [Fact]
        public void identical_books_have_the_same_hash_codes()
        {
            var jRRTolkein = new Author("J. R. R. Tolkein");
            var bookOne = new Book("The Hobbit", jRRTolkein);
            var bookTwo = new Book("The Hobbit", jRRTolkein);
            Assert.Equal(bookOne.GetHashCode(), bookTwo.GetHashCode());
        }
    }
}
