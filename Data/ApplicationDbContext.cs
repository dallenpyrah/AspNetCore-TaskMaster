using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taskmaster.Data
{
    public class ApplicationDbContext : DbContext
    {
        public readonly DbContextOptions options;

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            this.options = options;
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
