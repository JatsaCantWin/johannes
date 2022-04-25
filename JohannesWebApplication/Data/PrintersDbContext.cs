using JohannesWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace JohannesWebApplication.Data;

public class PrintersDbContext : DbContext
{
    public DbSet<PrinterModel> Printers { get; set; }
    public DbSet<MaterialModel> Models { get; set; }
    
    public PrintersDbContext(DbContextOptions<PrintersDbContext> options)
        : base(options)
    {
    }
}