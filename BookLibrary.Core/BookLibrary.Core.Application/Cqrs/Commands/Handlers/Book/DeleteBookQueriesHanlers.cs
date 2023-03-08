using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BookLibrary.Core.Application.Repositoriy;
using BookLibrary.Core.Application.RequestManager.Book.Commands;
using MediatR;

namespace BookLibrary.Core.Application.Cqrs.Queries.Handlers.Book
{
    public class DeleteBookQueriesHandlers : IRequestHandler<DeleteBookRequestModel, bool>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public DeleteBookQueriesHandlers(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public  Task<bool> Handle(DeleteBookRequestModel request, CancellationToken cancellationToken)
        {
            var isDeleted = _bookRepository.DeleteBook(request.Id);
            return Task.FromResult(isDeleted);

        }
    }
}
