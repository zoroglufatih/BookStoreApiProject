using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        private readonly BookStoreDbContext _dbContext;
        public int AuthorId { get; set; }

        public DeleteAuthorCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle()
        {
            var author = _dbContext.Authors.SingleOrDefault(x=> x.Id == AuthorId);
            if(author is null)
                throw new InvalidOperationException("Silinecek yazar bulunamadı");
            
            _dbContext.Authors.Remove(author);
            _dbContext.SaveChanges();
        }
        
    }
}