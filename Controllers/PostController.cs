using CQRS.Models;
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
        public async  Task<IActionResult> GetAllPost()
        {

            return View();
        }

        [HttpPost]
        [Route("addpost")]
        public async Task<IActionResult> AddPost([FromBody] PostModel model)
        {
            return View();
        }
    }
}
