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
    public class BookDeleteCommandHandler : IRequestHandler<BookCommandRequestModel, bool>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookDeleteCommandHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public Task<bool> Handle(BookCommandRequestModel request, CancellationToken cancellationToken)
        {
            var bookToDelete = _mapper.Map<Domain.Entity.Book>(request);
            var isDeleted = _bookRepository.Delete(bookToDelete);
            return Task.FromResult(isDeleted);
        }
    }
}
