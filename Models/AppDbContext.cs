﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessManager3.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasData(
                new Employee() { Id = -99, Name = "Mary", Email = "mary@gmail.com", DepartmentId = -99, GroupId = -1 },
                new Employee() { Id = -98, Name = "Stan", Email = "stan@gmail.com", DepartmentId = -99, GroupId = -1 },
                new Employee() { Id = -97, Name = "Mike", Email = "mike@gmail.com", DepartmentId = -99, GroupId = -1 });

            modelBuilder.Entity<Department>()
                .HasData(
                new Department() { DepartmentId = -99, Field = "IT", Name = "Programming Department" },
                new Department() { DepartmentId = -98, Field = "HR", Name = "Human Resorcues" },
                new Department() { DepartmentId = -97, Field = "AD", Name = "Advertisement Department" });

            modelBuilder.Entity<Department>()
                .HasMany(a => a.Employees);

            modelBuilder.Entity<Group>()
                .HasData(
                    new Group() { GroupId = -1, Name = "Cleaner", TodoId = -99 }
                );

            modelBuilder.Entity<Group>()
                .HasMany(a => a.Employees);

            modelBuilder.Entity<Todo>()
                .HasData(
                    new Todo() { ProblemId = -99, Title = "Spilled drink in basement", Descrpition = "Someone spilled drink all over the place in the basement", IsDone = false, GroupId = -1 });
            modelBuilder.Entity<Todo>()
                .HasOne(a => a.Group);
        }
    }
}