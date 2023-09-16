using IdentitySample.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentitySample.Models.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-S136OOG;Initial Catalog=IdentitySampleDB;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        #region DbSets
        public DbSet<Employee> Employees { get; set; }
        #endregion
    }
}
