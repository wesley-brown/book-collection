using Xunit;

namespace BookCollection.Domain.Tests
{
    public sealed class When_comparing_books
    {
        private readonly Author jRRTolkein;
        private readonly Book bookOne;
        private readonly Book bookTwo;

        public When_comparing_books()
        {
            jRRTolkein = new Author("J. R. R. Tolkein");
            bookOne = new Book("The Hobbit", jRRTolkein);
            bookTwo = new Book("The Hobbit", jRRTolkein);
        }

        [Fact]
        public void identical_books_have_the_same_hash_codes()
        {
            Assert.Equal(bookOne.GetHashCode(), bookTwo.GetHashCode());
        }

        [Fact]
        public void identical_books_are_equal()
        {
            Assert.Equal(bookOne, bookTwo);
        }
    }
}
