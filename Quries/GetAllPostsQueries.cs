using CQRS.Models;
using MediatR;

namespace CQRS.Quries
{
    public class GetAllPostsQueries : IRequest<ResponseModel<List<PostModel>>>
    {

    }
}
