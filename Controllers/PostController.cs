using CQRS.Models;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    public class PostController : Controller
    {
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
