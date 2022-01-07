using Microsoft.EntityFrameworkCore;
using Strony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strony.Data
{
    public class UserDbContext: DbContext
    {

        public UserDbContext()
        {
        }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}

