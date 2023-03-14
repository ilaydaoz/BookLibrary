using BookLibrary.Core.Application.Services.Commands.Book.Delete;
using BookLibrary.Core.Application.Services.Commands.Book.Insert;
using BookLibrary.Core.Application.Services.Queries.Book.GetAll;
using BookLibrary.Core.Application.Services.Queries.Book.GetById;
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
        //[FromQuery], [FromBody], [FromRoute] unutulmayacak!
        public async Task<IActionResult> Add([FromBody] BookInsertCommandRequestModel request) => Ok(await _mediator.Send(request));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var requestModel = new BookDeleteCommandRequestModel { Id = id };
            var response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var request = new BookGetByIdQueryRequestModel { Id = id };
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] BookGetAllQueryRequestModel request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}
