using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetConstructBlog.Models.Data
{
    public class Post
    {
        private const int SummaryLength = 150;
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string HtmlContent { get; set; }
        public string Summary => Regex.Replace(HtmlContent, "<.*?>", string.Empty).Substring(0, SummaryLength) + "...";
        public IEnumerable<Comment> Comments { get; set; }
    }
}
