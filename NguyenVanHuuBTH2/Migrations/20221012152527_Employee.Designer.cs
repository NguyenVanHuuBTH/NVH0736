// <auto-generated />
using System;
using NguyenVanHuuBTH2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NguyenVanHuuBTH2HoangKimHuanBTH2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221012152527_Employee")]
    partial class Employee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("NguyenVanHuuBTH2.Models.Customer", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaKH")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SĐT")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("NguyenVanHuuBTH2.Models.Person", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Personname")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("NguyenVanHuuBTH2.Models.Student", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("NguyenVanHuuBTH2.Models.Employee", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.Property<string>("Office")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}