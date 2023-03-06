using AutoMapper;
using BookLibrary.Core.Application.Cqrs.Queries.Response.Book;
using BookLibrary.Core.Application.Repositoriy;
using BookLibrary.Core.Application.RequestManager.Book;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Cqrs.Queries.Handlers.Book
{
    public class GetByIdBookQueriesHanlers : IRequestHandler<GetByIdBookRequestModel, GetbyIdBookResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public GetByIdBookQueriesHanlers(IBookRepository bookRepository, IMapper mapper )
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<GetbyIdBookResponse> Handle(GetByIdBookRequestModel request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetById(request.Id);
            var mapbook = _mapper.Map<GetbyIdBookResponse>(book);
            return mapbook;
        }

       
    }
}
