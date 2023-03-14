using AutoMapper;
using BookLibrary.Core.Application.Repositoriy;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Commands.Book.Insert
{
    public class BookInsertCommandHandler : IRequestHandler<BookInsertCommandRequestModel, BookInsertCommandResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookInsertCommandHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async  Task<BookInsertCommandResponse> Handle(BookInsertCommandRequestModel request, CancellationToken cancellationToken)
        {
            var mapbookRequest = _mapper.Map<Domain.Entity.Book>(request);
            var book =  _bookRepository.Add(mapbookRequest);
            var bookmap = _mapper.Map<BookInsertCommandResponse>(book);
            await _bookRepository.SaveAsync();
            return bookmap;

        }

    }
}
