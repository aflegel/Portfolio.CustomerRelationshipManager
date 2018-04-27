using System;
using DataFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataFramework.Data
{
	public partial class DataContext : DbContext
	{
		public virtual DbSet<Project> Projects { get; set; }
		public virtual DbSet<Department> Departments { get; set; }
		public virtual DbSet<ProjectSupplier> ProjectSuppliers { get; set; }
		public virtual DbSet<Salesperson> Salespersons { get; set; }
		public virtual DbSet<Part> LineItems { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(@"Server=Alex-Desktop;Database=QuotingTool;Trusted_Connection=True;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.Entity<ProjectSupplier>(entity =>
			{
				entity.HasKey(e => new { e.ProjectId, e.SupplierId });

				entity.HasOne(e => e.Project).WithMany(e => e.ProjectSuppliers);
				entity.HasOne(e => e.Supplier).WithMany(e => e.ProjectSuppliers).HasForeignKey(e => e.SupplierId);
			});

			modelBuilder.Entity<Project>(entity =>
			{
				entity.HasOne(e => e.Customer).WithMany(e => e.Projects).HasForeignKey(e => e.CustomerId);
			});

			modelBuilder.Entity<Part>(entity =>
			{
				entity.HasOne(e => e.ProjectSupplier).WithMany(e => e.LineItems);
				entity.HasOne(e => e.Department).WithMany(e => e.LineItems);
			});
		}
	}
}
