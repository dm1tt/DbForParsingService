
using DatabaseSchema.Model;
using Microsoft.EntityFrameworkCore;

namespace DatabaseSchema.DataBases;

public class MsSqlContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<ProductLink> ProductLinks { get; set; } = null!;
    public DbSet<Purchase> Purchases { get; set; } = null!;
    public DbSet<PurchaseStatement> PurchaseStatement { get; set; } = null!;
    public DbSet<User> User { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\csharpvscode\DatabaseSchema\ElectroTrackerDb.mdf;Integrated Security=True");
    }

}
