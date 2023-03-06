using AutoMapper;
using BookLibrary.Core.Application.Queries.Response;
using BookLibrary.Core.Application.Repositoriy;
using BookLibrary.Core.Application.RequestManager.Book;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Queries.Handlers
{
    public class BookQueriesHanlers : IRequestHandler<GetByIdBookRequestModel, BookGetbyIdResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookQueriesHanlers(IBookRepository bookRepository, IMapper mapper )
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookGetbyIdResponse> Handle(GetByIdBookRequestModel request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetById(request.Id);
            var mapbook = _mapper.Map<BookGetbyIdResponse>(book);
            return mapbook;
        }

       
    }
}
