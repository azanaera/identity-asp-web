using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace test_asp.Models
{
    public class MvcRecordContext : DbContext
    {
        public MvcRecordContext (DbContextOptions<MvcRecordContext> options)
            : base(options)
        {
        }

        public DbSet<test_asp.Models.Record> Record { get; set; }
        public DbSet<test_asp.Models.User> User { get; set; }
    }
}
