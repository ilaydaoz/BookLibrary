using AutoMapper;
using BookLibrary.Core.Application.Repositoriy;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Queries.Book.GetAll
{
    public class GetAllBookRequest : IRequest<List<BookGetAllQueryResponse>> { }
    public class BookGetAllQueryHandler : IRequestHandler<BookGetAllQueryRequestModel, List<BookGetAllQueryResponse>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookGetAllQueryHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<List<BookGetAllQueryResponse>> Handle(BookGetAllQueryRequestModel request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAll();
            var mappedBooks = _mapper.Map<List<BookGetAllQueryResponse>>(books);
            return mappedBooks;
        }
    }
}
