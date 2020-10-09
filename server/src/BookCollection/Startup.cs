using BookCollection.App.AddBook;
using BookCollection.App.DeleteBook;
using BookCollection.App.EditBook;
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
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("BookCollection"));
            });

            services.AddTransient<BookRepository, BookRepository>();
            services.AddTransient<BooksViewer, BooksViewer>();

            // Add book use case
            services.AddTransient<BookAdder, BookAdder>();

            // View authors use case
            services.AddTransient<AuthorRepository, AuthorRepository>();
            services.AddTransient<AuthorsViewer, AuthorsViewer>();

            // Delete book use case
            services.AddTransient<BookDeleter, BookDeleter>();

            // Edit book use case
            services.AddTransient<BookEditor, BookEditor>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
