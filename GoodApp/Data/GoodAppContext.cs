using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GoodApp.Models;

namespace GoodApp.Data
{
    public class GoodAppContext : DbContext
    {
        public GoodAppContext (DbContextOptions<GoodAppContext> options)
            : base(options)
        {
        }

        public DbSet<GoodApp.Models.User> User { get; set; } = default!;
    }
}
