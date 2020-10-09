using BookCollection.App.AddBook;
using BookCollection.App.ViewAuthors;
using BookCollection.App.ViewBooks;
using BookCollection.Data;
using BookCollection.Data.Authors;
using BookCollection.Data.Books;
using BookCollection.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookCollection
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookCollectionDbContext>(options => {
                options.UseInMemoryDatabase("BookCollections_DB");
            });
            services.AddTransient<BookRepository, BookRepository>();
            services.AddTransient<BooksViewer, BooksViewer>();

            // Add book use case
            services.AddTransient<BookAdder, BookAdder>();

            // View authors use case
            services.AddTransient<AuthorRepository, AuthorRepository>();
            services.AddTransient<AuthorsViewer, AuthorsViewer>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Add test data
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BookCollectionDbContext>();
                var jRRTolkein = new Author("J. R. R. Tolkein");
                context.Books.Add(new Book("The Hobbit", jRRTolkein));
                context.Books.Add(new Book("The Lord of the Rings", jRRTolkein));
                var georgeRRMartin = new Author("George R. R. Martin");
                context.Books.Add(new Book("A Game of Thrones", georgeRRMartin));
                context.Books.Add(new Book("A Clash of Kings", georgeRRMartin));
                var jKRowling = new Author("J. K. Rowling");
                context.Books.Add(new Book(
                    "Harry Potter and the Philosopher's Stone",
                    jKRowling));
                context.SaveChanges();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
