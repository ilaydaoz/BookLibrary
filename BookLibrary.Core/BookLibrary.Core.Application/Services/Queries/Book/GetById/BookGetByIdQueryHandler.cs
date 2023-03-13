using AutoMapper;
using BookLibrary.Core.Application.Repositoriy;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Queries.Book.GetById
{
    public class BookGetByIdQueryHandler : IRequestHandler<BookQueryRequestModel, BookGetByIdQueryResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookGetByIdQueryHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookGetByIdQueryResponse> Handle(BookQueryRequestModel request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetById(request.Id);
            var mapbook = _mapper.Map<BookGetByIdQueryResponse>(book);
            return mapbook;
        }
    }
}
