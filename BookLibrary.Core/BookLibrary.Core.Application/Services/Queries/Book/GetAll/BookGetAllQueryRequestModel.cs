using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Queries.Book.GetAll
{
    public class BookGetAllQueryRequestModel : IRequest<List<BookGetAllQueryResponse>>
    {
    }
}
