using CQRS.Models;
using MediatR;

namespace CQRS.Commands
{
    public class PostAddCommand : IRequest<ResponseModel<PostModel>>
    {
        public PostModel Post { get; set; }

        public PostAddCommand(PostModel post)
        {
            Post = post;
        }
    }
}
