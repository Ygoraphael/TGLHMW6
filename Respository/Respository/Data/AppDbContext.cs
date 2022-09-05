using Microsoft.EntityFrameworkCore;
using Respository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(string connectionString) : base(GetOptions(connectionString))
        {
        }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }
        public DbSet<Team> Team { get; set; }
        public DbSet<Player> Player { get; set; }
    }
}
