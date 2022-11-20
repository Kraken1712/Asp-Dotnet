using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonSite.BL;

namespace MonSite.DAL
{
    internal class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;
        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Blog>().HasData(
            new Blog
            {

                BlogId = 1,

                Url = "http://blogs.packtpub.com/dotnet"

            },
            new Blog
            {

                BlogId = 2,

                Url = "http://blogs.packtpub.com/dotnetcore"

            }
            );
            modelBuilder.Entity<Post>().HasData(
            new Post
            {
                PostId = 1,
                BlogId = 1,
                Title = "Dotnet 4.7 Released",
                Content = "Dotnet 4.7 Released Contents",
                PublishedDate = DateTime.Now
            },
            new Post
            {

                PostId = 2,
                BlogId = 1,
                Title = ".NET Core 1.1 Released",
                Content = ".NET Core 1.1 Released Contents",
                PublishedDate = DateTime.Now

            },
            new Post
            {

                PostId = 3,

                Title = "EF Core 1.1 Released",
                BlogId = 2,
                Content = "EF Core 1.1 Released Contents",
                PublishedDate = DateTime.Now

            }
            );

        }
    }

}
