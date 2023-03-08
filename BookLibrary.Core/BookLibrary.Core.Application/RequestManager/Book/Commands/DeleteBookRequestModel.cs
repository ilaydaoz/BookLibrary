using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.RequestManager.Book.Commands
{
    public class DeleteBookRequestModel : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
