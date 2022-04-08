using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                context.Authors.AddRange(
                    new Author
                    {
                        Name = "Eric",
                        Surname = "Ries",
                        BirthDate = new DateTime(1978,9,22)
                    },
                    new Author
                    {
                        Name = "Sarah",
                        Surname = "Smarsh",
                        BirthDate = new DateTime(1980, 10, 12)
                    },
                    new Author
                    {
                        Name = "Frank",
                        Surname = "Herbert ",
                        BirthDate = new DateTime(1920, 10, 8)
                    }
                );
                
                context.Genres.AddRange(
                    new Genre
                    {
                        Name = "Personal Growth"
                    },
                    new Genre
                    {
                        Name = "Science Fiction"
                    },
                    new Genre
                    {
                        Name = "Romance"
                    }
                );
                
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Lean Startup",
                        GenreId = 1,
                        PageCount = 200,
                        PublishDate = new DateTime(2001, 06, 12),
                        AuthorId = 1
                    },
                    new Book
                    {
                        Title = "Hearland",
                        GenreId = 2,
                        PageCount = 250,
                        PublishDate = new DateTime(2010, 05, 23),
                        AuthorId = 2
                    },
                    new Book
                    {
                        Title = "Dune",
                        GenreId = 2,
                        PageCount = 540,
                        PublishDate = new DateTime(2002, 12, 21),
                        AuthorId = 3
                    }
                );

                context.SaveChanges();
            }
        }
    }
}