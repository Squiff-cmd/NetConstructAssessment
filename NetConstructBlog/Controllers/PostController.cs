using Microsoft.AspNetCore.Mvc;
using NetConstructBlog.Models.Data;
using NetConstructBlog.Models.View;
using NetConstructBlog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetConstructBlog.Controllers
{
    public class PostController : Controller
    {

        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IActionResult> Post(int id)
        {
            var post = await _postRepository.GetPost(id);

            // Redirect to 404 Page            
            if (post is null)
            {
                return RedirectToAction("Error", "Home", new { statusCode = 404 });
            }

            var model = new PostViewModel
            {
                Post = post
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Reply(CommentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Oops, An error occurred and your comment was not posted.";
            }
            await _postRepository.AddReply(model.ParentComment, model.Comment);
            return Redirect($"Post/{model.ParentComment}");
        }

        [HttpPost]
        public async Task<IActionResult> Comment(CommentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Oops, An error occurred and your comment was not posted.";
            }
            await _postRepository.AddComment(model.ParentComment, model.Comment);
            return Redirect($"Post/{model.ParentComment}");
        }


    }
}
