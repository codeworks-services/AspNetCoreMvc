using AspNetCoreMvcCrud.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvcCrud.Data;

public partial class AspNetCoreMvcCrudContext : DbContext
{
    public AspNetCoreMvcCrudContext()
    {
    }

    public AspNetCoreMvcCrudContext(DbContextOptions<AspNetCoreMvcCrudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AspNetCoreMvcCrud;User ID=sa;Password=123;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF1A2E26F1F");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmpName).HasMaxLength(100);
            entity.Property(e => e.Office).HasMaxLength(50);
            entity.Property(e => e.Position).HasMaxLength(50);
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}