using JohannesWebApplication.Data.Migrations;
using JohannesWebApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JohannesWebApplication.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<PrinterModel> Printers { get; set; }
    public DbSet<MaterialModel> Materials { get; set; }
    public DbSet<OrderModel> Orders { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ApplicationUser>()
            .HasMany(t => t.PrinterModel)
            .WithMany(t => t.ApplicationUsers);
        modelBuilder.Entity<ApplicationUser>()
            .HasMany(t => t.CommissionsPut)
            .WithOne(t => t.Commisioner);
        modelBuilder.Entity<ApplicationUser>()
            .HasMany(t => t.CommissionsTaken)
            .WithOne(t => t.CommisionExecutioner);
        modelBuilder.Entity<ApplicationUser>()
            .HasMany(t => t.PotentialCommisions)
            .WithMany(t => t.PotentialExecutioners);
        modelBuilder.Entity<ApplicationUser>()
            .HasOne(t => t.Address)
            .WithOne(t => t.ApplicationUser)
            .HasForeignKey<AddressModel>(t => t.ApplicationUserForeignKey);
    }
}