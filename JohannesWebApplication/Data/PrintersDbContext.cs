using JohannesWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace JohannesWebApplication.Data;

public class PrintersDbContext : DbContext
{
    public DbSet<PrinterModel> Printers { get; set; }
    public DbSet<MaterialModel> Materials { get; set; }
    public DbSet<UserPrinter> UserPrinters { get; set; }
    public DbSet<OrderModel> Orders { get; set; }

    public PrintersDbContext(DbContextOptions<PrintersDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserPrinter>().HasNoKey();
    }
}