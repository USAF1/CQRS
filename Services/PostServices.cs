using CQRS.Interfaces;
using CQRS.Models;

namespace CQRS.Services
{
    public class PostServices : IPostInterface
    {

        private List<PostModel> posts = new List<PostModel>();

        public async Task<ResponseModel<PostModel>> AddPost(PostModel model)
        {
            ResponseModel<PostModel> responseModel = new ResponseModel<PostModel>();

            try
            {
                model.Id = new Guid();
                posts.Add(model);
                responseModel.Status = StatusCodes.Status200OK;
                responseModel.Message = "Data added succesfull";
                responseModel.Data = model;
            }
            catch (Exception ex)
            {
                responseModel.Status = StatusCodes.Status500InternalServerError;
                responseModel.Message = $"Data not added succesfull. Error: {ex.Message.ToString()}";
                responseModel.Data = model;

            }

            return  responseModel;
        }

        public async Task<ResponseModel<List<PostModel>>> GetAllPost()
        {
            ResponseModel<List<PostModel>> response = new ResponseModel<List<PostModel>>();
            try
            {
                response.Status = 200;
                if (posts.Count > 0)
                {
                    response.Message = "success";
                    response.Data = posts;
                }
                else
                {
                    response.Message = "No Posts Exits";
                    response.Data = posts;
                }
            }
            catch (Exception ex)
            {

                response.Status = StatusCodes.Status503ServiceUnavailable;
                response.Message = $"Error: {ex.Message.ToString()}";
                response.Data = null;
            }

            return response;
        }

        public Task<ResponseModel<PostModel>> GetPostById()
        {
            throw new NotImplementedException();
        }
    }
}
