using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace test_asp.Models
{
    public class test_aspContext : DbContext
    {
        public test_aspContext (DbContextOptions<test_aspContext> options)
            : base(options)
        {
        }

        public DbSet<test_asp.Models.Movie> Movie { get; set; }
    }
}
