﻿// <auto-generated />
using BookCollection.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookCollection.Migrations
{
    [DbContext(typeof(BookCollectionDbContext))]
    [Migration("20201009195328_Books")]
    partial class Books
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookCollection.Domain.Author", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Name = "J. R. R. Tolkein"
                        },
                        new
                        {
                            Name = "George R. R. Martin"
                        },
                        new
                        {
                            Name = "J. K. Rowling"
                        });
                });

            modelBuilder.Entity("BookCollection.Domain.Book", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Title");

                    b.HasIndex("AuthorName");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Title = "The Hobbit",
                            AuthorName = "J. R. R. Tolkein"
                        },
                        new
                        {
                            Title = "The Lord of the Rings",
                            AuthorName = "J. R. R. Tolkein"
                        },
                        new
                        {
                            Title = "A Game of Thrones",
                            AuthorName = "George R. R. Martin"
                        },
                        new
                        {
                            Title = "A Clash of Kings",
                            AuthorName = "George R. R. Martin"
                        },
                        new
                        {
                            Title = "Harry Potter and the Philosopher's Stone",
                            AuthorName = "J. K. Rowling"
                        });
                });

            modelBuilder.Entity("BookCollection.Domain.Book", b =>
                {
                    b.HasOne("BookCollection.Domain.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorName");
                });
#pragma warning restore 612, 618
        }
    }
}
