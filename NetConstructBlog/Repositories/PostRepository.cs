using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NetConstructBlog.Models.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetConstructBlog.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly string _jsonPath;
        private readonly JsonSerializerOptions _readOptions;
        private readonly JsonSerializerOptions _writeOptions;
        private readonly ILogger<PostRepository> _logger;

        public PostRepository(IOptionsSnapshot<AppSettings> appSettings, ILogger<PostRepository> logger)
        {
            _jsonPath = appSettings.Value.JsonPath;
            _readOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _writeOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
            _logger = logger;
        }

        public async Task<bool> AddComment(int id, Comment comment)
        {
            var json = await ReadJson();
            if (json == null) return false;

            // Retrieve current comments on post to get next Id for new comment
            var post = json.Where(x => x.Id == id).FirstOrDefault();

            // Get the next Id by incrementing the last post's last comment's Id.
            // If there are no comments then it is the first. 
            var nextId = post.Comments is not null
                ? post.Comments.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1
                : 1;

            comment.Id = nextId;
            comment.Date = DateTime.Now;

            // Append the new comment to the existing posts comments
            json = json.Select(x =>
            {
                if (x.Id == id)
                {
                    x.Comments = x.Comments is null 
                        ? new List<Comment> { comment } 
                        : x.Comments.Append(comment);
                }
                return x;
            });

            // overwrite the current JSON file
            return await WriteJson(json);
        }

        public async Task<bool> AddReply(int id, Comment comment)
        {
            var json = await ReadJson();
            if (json == null) return false;

            // Find the post 
            var post = json.Where(x => x.Comments.Any(y => y.Id == id)).FirstOrDefault();
            var nextId = post.Comments.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            comment.Id = nextId;
            comment.Date = DateTime.Now;

            json = json.Select(x =>
            {
                if (x.Id == nextId)
                {
                    x.Comments = x.Comments.Select(x =>
                   {
                       if (x.Id == id)
                       {
                           x.Replies = x.Replies.Append(comment);
                       }
                       return x;
                   });                 
                }
                return x;
            });

            return true;
        }

 
        public async Task<Post> GetPost(int id)
        {
            var blogPosts = await ReadJson();
            return blogPosts.Where(bp => bp.Id == id).FirstOrDefault();
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            return await ReadJson();
        }

        private async Task<IEnumerable<Post>> ReadJson()
        {
            IEnumerable<Post> result = null;

            try
            {
                var json = await File.ReadAllTextAsync(_jsonPath);
                result = JsonSerializer.Deserialize<IEnumerable<Post>>(json, _readOptions);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error occurred while parsing JSON", ex);
            }

            return result;
        }

        private async Task<bool> WriteJson(IEnumerable<Post> json)
        {
            var serializedJson = "";
            try
            {
                serializedJson = JsonSerializer.Serialize(json, _writeOptions);
                await File.WriteAllTextAsync(_jsonPath, serializedJson);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error occurred while parsing JSON", ex);
            }

            return true;
        }

    }
}
