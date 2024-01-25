using CQRS.Commands;
using CQRS.Interfaces;
using CQRS.Models;
using MediatR;

namespace CQRS.Handlers
{
    public class AddPostHandler : IRequestHandler<PostAddCommand, ResponseModel<PostModel>>
    {
        private readonly IPostInterface _postService;

        public AddPostHandler(IPostInterface postService)
        {
            _postService = postService;
        }

        public async Task<ResponseModel<PostModel>> Handle(PostAddCommand request, CancellationToken cancellationToken)
        {
            return await _postService.AddPost(request.Post);
        }
    }
}
