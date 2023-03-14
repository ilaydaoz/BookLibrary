using AutoMapper;
using BookLibrary.Core.Application.Repositoriy;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Commands.Book.Delete
{
    public class BookDeleteCommandHandler : IRequestHandler<BookDeleteCommandRequestModel, bool>
    {
        private readonly IBookRepository _bookRepository;
        

        public BookDeleteCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
          
        }

        public async Task<bool> Handle(BookDeleteCommandRequestModel request, CancellationToken cancellationToken)
        {
            var isDeleted = _bookRepository.Delete(new Domain.Entity.Book { Id = request.Id });
            await _bookRepository.SaveAsync();
            return isDeleted;
        }
    }
}
