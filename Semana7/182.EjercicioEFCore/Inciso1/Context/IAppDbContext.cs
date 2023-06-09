using System;
using Inciso1.Models;
using Microsoft.EntityFrameworkCore;

namespace Inciso1.Context
{
	public interface IAppDbContext
	{
        public DbSet<COLEGIO> COLEGIO { get; set; }
        public DbSet<CLASE> CLASE { get; set; }
        public DbSet<ALUMNO> ALUMNO { get; set; }
        public DbSet<PROFESOR> PROFESOR { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync
            (bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
    }
}

