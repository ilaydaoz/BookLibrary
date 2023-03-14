using BookLibrary.Core.Application.Services.Commands.Book.Delete;
using BookLibrary.Core.Application.Services.Commands.Book.Insert;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Presentation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// [HttpPost]
        /// public async Task<IActionResult> Add([FromBody] BookCommandRequestModel request)
        ///    => Ok(await _mediator.Send(request));
        ///    

        [HttpPost]
        public async Task<IActionResult> Add(BookInsertCommandRequestModel request) => Ok(await _mediator.Send(request));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var book = new BookDeleteCommandRequestModel { Id = id };
            await _mediator.Send(book);
            return Ok();
        }


    }
}
