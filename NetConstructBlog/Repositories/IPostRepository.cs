using NetConstructBlog.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetConstructBlog.Repositories
{
    public interface IPostRepository
    {
        public Task<IEnumerable<Post>> GetPosts();
        public Task<Post> GetPost(int id);
        public Task<bool> AddComment(int id, Comment comment);
        public Task<bool> AddReply(int id, Comment comment);
    }
}
