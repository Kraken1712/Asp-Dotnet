using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyForum.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForum.DAL
{
    public class MyForumDbContext : IdentityDbContext<User>
    {
        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Post>? Posts { get; set; }
        public override DbSet<User>? Users { get; set; }
        public MyForumDbContext(DbContextOptions<MyForumDbContext> options)
            : base(options)
        {
        }
    }
}
