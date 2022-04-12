using System;
using WebApi.DBOperations;
using WebApi.Entities;

namespace TestSetup
{
    public static class Authors
    {
        public static void AddAuthors(this BookStoreDbContext context)
        {
            context.Authors.AddRange(
                new Author { Name = "Eric", Surname = "Ries", BirthDate = new DateTime(1978,9,22) },
                new Author { Name = "Sarah", Surname = "Smarsh", BirthDate = new DateTime(1980, 10, 12) },
                new Author { Name = "Frank", Surname = "Herbert ", BirthDate = new DateTime(1920, 10, 8) }
        );
        }
    }
}