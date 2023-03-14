using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Queries.Book.GetAll
{
    public class BookGetAllQueryResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        public bool Ordered { get; set; } = false;
        public Guid? CategoryId { get; set; }
    }
}
