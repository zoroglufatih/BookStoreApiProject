using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand
    {
        private readonly BookStoreDbContext _dbContext;
        public int AuthorId { get; set; }
        public UpdateAuthorModel Model { get; set; }
        public UpdateAuthorCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle()
        {
            var author = _dbContext.Authors.SingleOrDefault(x=> x.Id == AuthorId);

            if(author is null)
                throw new InvalidOperationException("Güncellenecek yazar bulunamadı");
            
            author.Name = Model.Name;
            author.Surname = Model.Surname;
            author.BirthDate = Model.BirthDate;

            _dbContext.SaveChanges();
        }
    }
    
    public class UpdateAuthorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}