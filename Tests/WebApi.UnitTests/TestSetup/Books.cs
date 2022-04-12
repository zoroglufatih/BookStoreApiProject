using System;
using WebApi.DBOperations;
using WebApi.Entities;

namespace TestSetup
{
    public static class Books
    {
        public static void AddBooks(this BookStoreDbContext context)
        {
             context.Books.AddRange(
                new Book { Title = "Lean Startup", GenreId = 1, PageCount = 200, PublishDate = new DateTime(2001, 06, 12), AuthorId = 1 },
                new Book { Title = "Hearland", GenreId = 2, PageCount = 250, PublishDate = new DateTime(2010, 05, 23), AuthorId = 2 },
                new Book { Title = "Dune", GenreId = 2, PageCount = 540, PublishDate = new DateTime(2002, 12, 21), AuthorId = 3 }
            );
        }
    }
}