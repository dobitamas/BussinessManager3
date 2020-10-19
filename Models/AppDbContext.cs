using Microsoft.EntityFrameworkCore;
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
                new Employee() { EmployeeId = -99, Name = "Mary", Email = "mary@gmail.com", DepartmentId = -99, GroupId = -1 },
                new Employee() { EmployeeId = -98, Name = "Stan", Email = "stan@gmail.com", DepartmentId = -99, GroupId = -1 },
                new Employee() { EmployeeId = -97, Name = "Mike", Email = "mike@gmail.com", DepartmentId = -99, GroupId = -1 });

            modelBuilder.Entity<Department>()
                .HasData(
                new Department() { DepartmentId = -99, Field = "IT", Name = "Programming Department", Employees = null },
                new Department() { DepartmentId = -98, Field = "HR", Name = "Human Resorcues", Employees = null },
                new Department() { DepartmentId = -97, Field = "AD", Name = "Advertisement Department", Employees = null });

            modelBuilder.Entity<Group>()
                .HasData(
                    new Group() { GroupId = -1, Name = "Cleaner" }
                );

            modelBuilder.Entity<Todo>()
                .HasData(
                    new Todo() { TodoId = -99, Title = "Spilled drink in basement", Descrpition = "Someone spilled drink all over the place in the basement", IsDone = false, GroupId = -1 });

            modelBuilder.Entity<Department>()
                .HasMany(c => c.Employees)
                .WithOne(e => e.Department);

            modelBuilder.Entity<Group>()
                .HasMany(c => c.Employees)
                .WithOne(e => e.Group);
        }
    }
}