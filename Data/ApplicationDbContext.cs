using Microsoft.EntityFrameworkCore;
using QRMenuSystem.Models; // Modellerimizin olduğu yeri ekliyoruz

namespace QRMenuSystem.Data
{
    // DbContext, EF Core'un veritabanı yönetim merkezidir.
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Aşağıdaki her bir DbSet, veritabanında bir tabloya karşılık gelir.
        public DbSet<Table> Tables { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}