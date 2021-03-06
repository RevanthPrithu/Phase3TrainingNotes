// <auto-generated />
using EfCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfCoreApp.Migrations
{
    [DbContext(typeof(EmpDbContext))]
    partial class EmpDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfCoreApp.Models.EmpModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Job")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("tblEmployees");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            EName = "Shivani",
                            Job = "Manager",
                            Salary = 10000.0
                        },
                        new
                        {
                            Id = 1002,
                            EName = "Yuvaraj",
                            Job = "Developer",
                            Salary = 9000.0
                        },
                        new
                        {
                            Id = 1003,
                            EName = "Kiran",
                            Job = "Trainer",
                            Salary = 85000.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
