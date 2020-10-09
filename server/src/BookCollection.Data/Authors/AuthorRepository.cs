using BookCollection.Domain;
using System.Collections.Generic;

namespace BookCollection.Data.Authors
{
    public sealed class AuthorRepository
    {
        private readonly BookCollectionDbContext context;

        public AuthorRepository(BookCollectionDbContext context)
        {
            this.context = context;
        }

        public List<Author> Authors
        {
            get
            {
                return new List<Author>(context.Authors);
            }
        }

        public Author AuthorWithName(string name)
        {
            var author = context.Authors.Find(name);
            if (author == null)
            {
                var newAuthor = new Author(name);
                context.Add(newAuthor);
                context.SaveChanges();
                return newAuthor;
            }
            else
            {
                return author;
            }
        }
    }
}
