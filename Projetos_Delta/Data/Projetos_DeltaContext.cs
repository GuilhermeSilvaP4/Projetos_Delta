using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projetos_Delta.Models;

namespace Projetos_Delta.Data
{
    public class Projetos_DeltaContext : DbContext
    {
        public Projetos_DeltaContext (DbContextOptions<Projetos_DeltaContext> options)
            : base(options)
        {
        }

        public DbSet<Projetos_Delta.Models.Employee> Employees { get; set; }

        public DbSet<Projetos_Delta.Models.Project> Projetos { get; set; }

        public DbSet<Projetos_Delta.Models.Request> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Request>().ToTable("Request");
            modelBuilder.Entity<Project>().ToTable("Projeto");
        }
    }
}
