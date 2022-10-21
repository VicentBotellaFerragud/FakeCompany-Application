using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FakeCompany_Application.Data.Models
{
    public partial class FakeCompanyContext : DbContext
    {
        public FakeCompanyContext()
        {
        }

        public FakeCompanyContext(DbContextOptions<FakeCompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeSale> EmployeeSales { get; set; } = null!;
        public virtual DbSet<Manager> Managers { get; set; } = null!;
        public virtual DbSet<ManagerSale> ManagerSales { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FakeCompany;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).ValueGeneratedNever();

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Employees__Depar__5EBF139D");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Employees__Manag__5DCAEF64");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Employees__Proje__5FB337D6");
            });

            modelBuilder.Entity<EmployeeSale>(entity =>
            {
                entity.Property(e => e.EmployeeSaleId).ValueGeneratedNever();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSales)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__EmployeeS__Emplo__6FE99F9F");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.Property(e => e.ManagerId).ValueGeneratedNever();

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Managers__Depart__59FA5E80");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Managers__Projec__5AEE82B9");
            });

            modelBuilder.Entity<ManagerSale>(entity =>
            {
                entity.Property(e => e.ManagerSaleId).ValueGeneratedNever();

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.ManagerSales)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__ManagerSa__Manag__72C60C4A");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectId).ValueGeneratedNever();

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
