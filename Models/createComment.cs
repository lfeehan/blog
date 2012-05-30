using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDemo.Models
{
    public class createComment
    {
        public int postid { set; get; }
        public Comment comment { set; get; }
    }
}