using Microsoft.EntityFrameworkCore;
using OnDemandCarWash.Model.cs;
namespace OnDemandCarWash.DataContext
{

    public class OnDemandDbContext : DbContext
        {
            public OnDemandDbContext(DbContextOptions dbcontextOptions) : base(dbcontextOptions) { }

            public DbSet<Addon> Addons { set; get; }
            public DbSet<Car> Cars { set; get; }
            public DbSet<Order> Orders { set; get; }
            public DbSet<Payment> Payments { set; get; }

            public DbSet<User> Users { set; get; }
        }
    

}
