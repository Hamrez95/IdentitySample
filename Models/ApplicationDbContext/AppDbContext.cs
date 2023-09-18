using IdentitySample.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentitySample.Models.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) 
        : base(dbContextOptions)
        {

        }

        #region DbSets
        public DbSet<Employee> Employees { get; set; }
        #endregion
    }
}
