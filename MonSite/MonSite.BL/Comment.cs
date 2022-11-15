using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonSite.BL
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? Title { get; set; }
        public string? CommentText { get; set; }
        public string? Author { get; set; }
        public Post? Post { get; set; }
    }
}
