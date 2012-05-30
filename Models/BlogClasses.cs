using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int posterid { get; set; }
        public string Title { get; set; }
        public string Tag { get; set; }
        public DateTime DateCreated { get; set; }
        public string Content { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        //public Post Post { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
  
}