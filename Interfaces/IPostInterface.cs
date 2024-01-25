using CQRS.Models;

namespace CQRS.Interfaces
{
    public interface IPostInterface
    {

        Task<ResponseModel<PostModel>> GetPostById();

        Task<ResponseModel<List<PostModel>>> GetAllPost();

        Task<ResponseModel<PostModel>> AddPost(PostModel model);
    }
}
