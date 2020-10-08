using Xunit;

namespace BookCollection.Domain.Tests
{
    public sealed class When_comparing_authors
    {
        private readonly Author authorOne;
        private readonly Author authorTwo;

        public When_comparing_authors()
        {
            authorOne = new Author("J. R. R. Tolkein");
            authorTwo = new Author("J. R. R. Tolkein");
        }

        [Fact]
        public void identical_authors_have_the_same_hash_codes()
        {
            Assert.Equal(authorOne.GetHashCode(), authorTwo.GetHashCode());
        }

        [Fact]
        public void identical_authors_are_equal()
        {
            Assert.Equal(authorOne, authorTwo);
        }

        [Fact]
        public void authors_are_sorted_by_name()
        {
            var authorThree = new Author("George R. R. Martin");
            Assert.True(authorOne.CompareTo(authorTwo) == 0);
            Assert.True(authorOne.CompareTo(authorThree) > 0);
            Assert.True(authorThree.CompareTo(authorOne) < 0);
        }
    }
}
