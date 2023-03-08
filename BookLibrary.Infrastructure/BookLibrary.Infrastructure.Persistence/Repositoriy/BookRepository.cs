using BookLibrary.Core.Application.Repositoriy;
using BookLibrary.Core.Domain.Entity;
using BookLibrary.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Persistence.Repositoriy
{
    public class BookRepository : BaseRepository<Book,BLDbContext>, IBookRepository
    {
        public BookRepository(BLDbContext context) : base(context)
        {
        }

        public bool DeleteBook(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> InsertAsync(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
