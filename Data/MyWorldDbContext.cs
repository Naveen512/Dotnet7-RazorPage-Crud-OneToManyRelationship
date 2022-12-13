using dot7.razor.crudsample.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace dot7.razor.crudsample.Data;


public class MyWorldDbContext : DbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> context) : base(context)
    {

    }

    public DbSet<Employee> Employee { get; set; }

    public DbSet<EmployeeAddresses> EmployeeAddresses{get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeAddresses>()
        .HasOne(_ => _.Employee)
        .WithMany(a => a.EmployeeAddresses)
        .HasForeignKey(p => p.EmployeeId)
        .OnDelete(DeleteBehavior.Cascade);
    }
}