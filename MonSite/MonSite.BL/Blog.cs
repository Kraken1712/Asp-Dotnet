using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonSite.BL
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string? Url { get; set; }
        public virtual LinkedList<Post>? Posts { get; set; }
    }
}
