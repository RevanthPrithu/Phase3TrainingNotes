using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAppApi02.Model
{
    public partial class revanthdbContext : DbContext
    {
        public revanthdbContext()
        {
        }

        public revanthdbContext(DbContextOptions<revanthdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=(local);integrated security=true;database=revanthdb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.ToTable("tblDepartments");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Dname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dname");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("location");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.ToTable("tblEmployees");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Job)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("job");

                entity.Property(e => e.Salary).HasColumnName("salary");
                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK__tb1Employ__depti__267ABA7A");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
