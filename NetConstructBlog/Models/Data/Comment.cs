using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetConstructBlog.Models.Data
{
    public class Comment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set;  }

        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set;  }

        public IEnumerable<Comment> Replies { get; set; }
    }
}
