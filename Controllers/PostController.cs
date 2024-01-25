using CQRS.Commands;
using CQRS.Models;
using CQRS.Quries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    public class PostController : Controller
    {

        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getallpost")]
        public async  Task<ResponseModel<List<PostModel>>> GetAllPost()
        {
            var query = new GetAllPostsQueries();
            ResponseModel<List<PostModel>> data  = await _mediator.Send(query);

            return data;    
        }

        [HttpPost]
        [Route("addpost")]
        public async Task<ResponseModel<PostModel>> AddPost([FromBody] PostModel model)
        {
            var command = new PostAddCommand(model);
            return await _mediator.Send(command);
        }
    }
}
