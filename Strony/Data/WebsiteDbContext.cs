using Microsoft.EntityFrameworkCore;
using Strony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strony.Data
{
    public class WebsiteDbContext : DbContext
    {
        public WebsiteDbContext()
        {
        }

        public WebsiteDbContext(DbContextOptions<WebsiteDbContext> options) : base(options) {

        }

        public DbSet<Website>Websites {get; set; }

        public DbSet<Strony.Models.User> User { get; set; }
    }
}
