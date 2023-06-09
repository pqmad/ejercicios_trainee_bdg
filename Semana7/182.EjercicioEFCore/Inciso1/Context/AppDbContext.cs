using System;
using Inciso1.Models;
using Microsoft.EntityFrameworkCore;

namespace Inciso1.Context
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<COLEGIO> COLEGIO { get; set; }
        public DbSet<CLASE> CLASE { get; set; }
        public DbSet<ALUMNO> ALUMNO { get; set; }
        public DbSet<PROFESOR> PROFESOR { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}

