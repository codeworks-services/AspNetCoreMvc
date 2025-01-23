using AspNetCoreMvcCrud.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvcCrud.UI.DataAccess.Models;

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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
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