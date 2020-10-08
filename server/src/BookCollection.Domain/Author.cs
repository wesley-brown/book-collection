using System;
using System.ComponentModel.DataAnnotations;

namespace BookCollection.Domain
{
    /// <summary>
    /// A person who writes books.
    /// </summary>
    public sealed class Author : IComparable
    {
        /// <summary>
        /// The name of this Author.
        /// </summary>
        [Key]
        public string Name { get; private set; }

        /// <summary>
        /// Create an author with a given name.
        /// </summary>
        /// <param name="name">The name of the author.</param>
        public Author(string name)
        {
            Name = name;
        }

        // For Entity Framework
        private Author()
        {
        }

        public override int GetHashCode()
        {
            int hash = 7;
            hash = 31 * hash + Name.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Author otherAuthor = (Author)obj;
                return Name.Equals(otherAuthor.Name);
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Author otherAuthor = obj as Author;
            if (otherAuthor != null)
            {
                return Name.CompareTo(otherAuthor.Name);
            }
            else
            {
                throw new ArgumentException("Object is not an Author");
            }
        }

        public override string ToString()
        {
            return "<Author: Name=" + Name + ">";
        }
    }
}
