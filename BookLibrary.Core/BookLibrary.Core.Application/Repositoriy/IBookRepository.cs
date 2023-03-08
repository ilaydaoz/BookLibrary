using BookLibrary.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Repositoriy
{
    public interface IBookRepository : IBaseRepository<Book>
    {
        public bool DeleteBook(Guid id);
    }
}
