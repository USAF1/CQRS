using CQRS.Interfaces;
using CQRS.Models;
using CQRS.Quries;
using MediatR;

namespace CQRS.Handlers
{
    public class GetAllPostsHandler : IRequestHandler<GetAllPostsQueries, ResponseModel<List<PostModel>>>
    {

        private readonly IPostInterface _postService;

        public GetAllPostsHandler( IPostInterface postService)
        {
            _postService = postService;
        }

        public Task<ResponseModel<List<PostModel>>> Handle(GetAllPostsQueries request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
