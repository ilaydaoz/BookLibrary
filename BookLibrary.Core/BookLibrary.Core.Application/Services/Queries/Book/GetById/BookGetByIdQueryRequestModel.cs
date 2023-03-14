using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Queries.Book.GetById
{
    public class BookGetByIdQueryRequestModel : IRequest<BookGetByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
