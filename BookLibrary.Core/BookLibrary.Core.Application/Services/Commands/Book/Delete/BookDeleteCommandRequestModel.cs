using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Commands.Book.Delete
{
    public class BookDeleteCommandRequestModel : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
