using AutoMapper;
using BookLibrary.Core.Application.Cqrs.Queries.Response.Book;
using BookLibrary.Core.Application.Repositoriy;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Cqrs.Queries.Handlers.Book
{
    public class GetAllBookRequest : IRequest<List<GetAllBookResponse>> { }

    public class GetAllBookQueriesHanlers : IRequestHandler<GetAllBookRequest, List<GetAllBookResponse>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public GetAllBookQueriesHanlers(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllBookResponse>> Handle(GetAllBookRequest request, CancellationToken cancellationToken)
        {
            var books = _bookRepository.GetAll();
            var mappedBooks = _mapper.Map<List<GetAllBookResponse>>(books);
            return mappedBooks;
        }
    }
}
