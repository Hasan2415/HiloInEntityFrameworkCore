using HiloEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace HiloEntityFramework;

public class EFDataContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().Property(_ => _.Id)
            .UseHiLo("EmployeeKey");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=test-DB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}