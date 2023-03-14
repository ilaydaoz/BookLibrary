using BookLibrary.Core.Application.Services.Queries.Book.GetAll;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Commands.Book.Insert
{
    public class BookInsertCommandRequestModel : IRequest<BookInsertCommandResponse>
    {
        public string Title { get; set; } 
        public string Author { get; set; } 
        public float Price { get; set; }
        public bool Ordered { get; set; }
        public Guid CategoryId { get; set; }
    }
}
