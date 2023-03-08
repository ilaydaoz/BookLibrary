using BookLibrary.Core.Application.Cqrs.Queries.Response.Book;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.RequestManager.Book
{
    public class GetAllBookRequestModel : IRequest<GetAllBookResponse>
    {
    }
}
