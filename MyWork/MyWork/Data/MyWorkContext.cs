using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Data
{
    public class MyWorkContext : DbContext
    {
        public MyWorkContext(DbContextOptions<MyWorkContext> options)
            : base(options)
        {

        }

        public DbSet<Activity> Activity { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Note> Note { get; set; }

        
    }
}
