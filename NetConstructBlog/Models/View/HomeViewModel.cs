using NetConstructBlog.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetConstructBlog.Models.View
{
    public class HomeViewModel
    {
        public IEnumerable<Post> Blogs { get; set; }
    }
}
