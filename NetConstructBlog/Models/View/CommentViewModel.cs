using NetConstructBlog.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetConstructBlog.Models.View
{
    public class CommentViewModel
    {
        public int ParentComment { get; set; }
        public Comment Comment { get; set; }
    }
}
