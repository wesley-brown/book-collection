using BookCollection.Data.Authors;
using BookCollection.Domain;
using System.Collections.Generic;

namespace BookCollection.App.ViewAuthors
{
    public sealed class AuthorsViewer
    {
        private readonly AuthorRepository authorRepository;

        public AuthorsViewer(AuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return authorRepository.Authors;
        }
    }
}
