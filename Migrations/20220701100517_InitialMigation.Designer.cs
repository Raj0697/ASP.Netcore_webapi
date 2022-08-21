﻿// <auto-generated />
using System;
using EmployeeRegister.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeRegister.Migrations
{
    [DbContext(typeof(Employee_Dept_Context))]
    [Migration("20220701100517_InitialMigation")]
    partial class InitialMigation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeRegister.Models.Department", b =>
                {
                    b.Property<Guid>("Department_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Department_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Department_ID");

                    b.ToTable("department");
                });

            modelBuilder.Entity("EmployeeRegister.Models.Employee", b =>
                {
                    b.Property<Guid>("Employee_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Department_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("Varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<Guid>("Manager_ID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Employee_ID");

                    b.HasIndex("Department_ID")
                        .IsUnique();

                    b.ToTable("employees");
                });

            modelBuilder.Entity("EmployeeRegister.Models.Employee", b =>
                {
                    b.HasOne("EmployeeRegister.Models.Department", "department")
                        .WithOne("Employee")
                        .HasForeignKey("EmployeeRegister.Models.Employee", "Department_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}