using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using layoutc.Models;

namespace layoutc.Data
{
    public class layoutcContext : DbContext
    {
        public layoutcContext (DbContextOptions<layoutcContext> options)
            : base(options)
        {
        }

        public DbSet<layoutc.Models.Student> Student { get; set; } = default!;
    }
}
