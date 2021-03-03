using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetConstructBlog.Models;
using NetConstructBlog.Models.View;
using NetConstructBlog.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NetConstructBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPostRepository _postRepository;

        public HomeController(ILogger<HomeController> logger, IPostRepository postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public async Task<IActionResult> Home()
        {
            var model = new HomeViewModel
            {
                Blogs = await _postRepository.GetPosts()
            };

            return View(model);
        }

        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404)
            {
                // If 404 log the attempted path as a warning
                var statusFeature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
                if (statusFeature is not null)
                {
                    _logger.LogWarning("handled 404 for url: {OriginalPath}", statusFeature.OriginalPath);
                }
            }
            return View(statusCode);
        }
    }
}
