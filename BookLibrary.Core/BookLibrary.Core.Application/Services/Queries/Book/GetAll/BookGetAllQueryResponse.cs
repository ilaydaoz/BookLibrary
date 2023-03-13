using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Queries.Book.GetAll
{
    public class BookGetAllQueryResponse
    {
        public Guid? Id { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
