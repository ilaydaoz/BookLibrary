using AutoMapper;
using BookLibrary.Core.Application.Cqrs.Commands.Response.Book;
using BookLibrary.Core.Application.Repositoriy;
using BookLibrary.Core.Application.RequestManager.Book.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Cqrs.Commands.Handlers.Book
{
    public class InsertBookCommandsHandlers : IRequestHandler<InsertBookRequestModel, InsertBookResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public InsertBookCommandsHandlers(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<InsertBookResponse> Handle(InsertBookRequestModel request, CancellationToken cancellationToken)
        {
            var mapbookRequest = _mapper.Map<Domain.Entity.Book>(request);
            var book = await _bookRepository.InsertAsync(mapbookRequest);
            var bookmap = _mapper.Map<InsertBookResponse>(book);
            return bookmap;
        }

    }
}
