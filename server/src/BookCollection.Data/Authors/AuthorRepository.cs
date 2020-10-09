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

        public IEnumerable<Author> Authors
        {
            get
            {
                return context.Authors;
            }
        }
    }
}
