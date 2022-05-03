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

        public DbSet<Projetos_Delta.Models.Employee> Employee { get; set; }

        public DbSet<Projetos_Delta.Models.Projeto> Projeto { get; set; }

        public DbSet<Projetos_Delta.Models.Request> Request { get; set; }
    }
}
