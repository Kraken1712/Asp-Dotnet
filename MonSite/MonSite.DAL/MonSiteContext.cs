using Microsoft.EntityFrameworkCore;
using MonSite.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonSite.DAL
{
    public class MonSiteContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(LocalDB)\MSSQLLocalDB; Initial Catalog=BDENIT2022;Integrated Security=true");
        }
        */
        public MonSiteContext(DbContextOptions<MonSiteContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }
    }
}
