using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonSite.DAL
{
    public class DataContextFactory : IDesignTimeDbContextFactory<MonSiteContext>
    {
        public MonSiteContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MonSiteContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MySiteDB;Trusted_Connection=True; MultipleActiveResultSets = true");
            return new MonSiteContext(optionsBuilder.Options);
        }
    }
}
