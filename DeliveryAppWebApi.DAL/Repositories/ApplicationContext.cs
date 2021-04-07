using DeliveryManagement.DataAccess.Entities.SQLEntities;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<SqlCall> Calls { get; set; }
    public DbSet<SqlCar> Cars { get; set; }
    public DbSet<SqlClient> Clients { get; set; }
    public DbSet<SqlDeliveryMen> DeliveryMen { get; set; }
    public DbSet<SqlOrder> Orders { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SqlCall>().ToTable("Call");
        modelBuilder.Entity<SqlCar>().ToTable("Car");
        modelBuilder.Entity<SqlClient>().ToTable("Client");
        modelBuilder.Entity<SqlDeliveryMen>().ToTable("DeliveryMen");
        modelBuilder.Entity<SqlOrder>().ToTable("Order");
    }
}