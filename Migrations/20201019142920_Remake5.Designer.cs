﻿// <auto-generated />
using BussinessManager3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BussinessManager3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201019142920_Remake5")]
    partial class Remake5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BussinessManager3.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = -99,
                            Field = "IT",
                            Name = "Programming Department"
                        },
                        new
                        {
                            DepartmentId = -98,
                            Field = "HR",
                            Name = "Human Resorcues"
                        },
                        new
                        {
                            DepartmentId = -97,
                            Field = "AD",
                            Name = "Advertisement Department"
                        });
                });

            modelBuilder.Entity("BussinessManager3.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GroupId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = -99,
                            DepartmentId = -99,
                            Email = "mary@gmail.com",
                            GroupId = -1,
                            Name = "Mary"
                        },
                        new
                        {
                            EmployeeId = -98,
                            DepartmentId = -99,
                            Email = "stan@gmail.com",
                            GroupId = -1,
                            Name = "Stan"
                        },
                        new
                        {
                            EmployeeId = -97,
                            DepartmentId = -99,
                            Email = "mike@gmail.com",
                            GroupId = -1,
                            Name = "Mike"
                        });
                });

            modelBuilder.Entity("BussinessManager3.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = -1,
                            Name = "Cleaner"
                        });
                });

            modelBuilder.Entity("BussinessManager3.Models.Todo", b =>
                {
                    b.Property<int>("TodoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Descrpition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDone")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TodoId");

                    b.HasIndex("GroupId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            TodoId = -99,
                            Descrpition = "Someone spilled drink all over the place in the basement",
                            GroupId = -1,
                            IsDone = false,
                            Title = "Spilled drink in basement"
                        });
                });

            modelBuilder.Entity("BussinessManager3.Models.Employee", b =>
                {
                    b.HasOne("BussinessManager3.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BussinessManager3.Models.Group", "Group")
                        .WithMany("Employees")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BussinessManager3.Models.Todo", b =>
                {
                    b.HasOne("BussinessManager3.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}