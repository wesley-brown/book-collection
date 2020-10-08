using Xunit;

namespace BookCollection.Domain.Tests
{
    public sealed class When_comparing_authors
    {
        [Fact]
        public void identical_authors_have_the_same_hash_codes()
        {
            var authorOne = new Author("J. R. R. Tolkein");
            var authorTwo = new Author("J. R. R. Tolkein");
            Assert.Equal(authorOne.GetHashCode(), authorTwo.GetHashCode());
        }

        [Fact]
        public void identical_authors_are_equal()
        {
            var authorOne = new Author("J. R. R. Tolkein");
            var authorTwo = new Author("J. R. R. Tolkein");
            Assert.Equal(authorOne, authorTwo);
        }
    }
}
