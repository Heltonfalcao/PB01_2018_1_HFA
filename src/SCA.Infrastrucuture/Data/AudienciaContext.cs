using Microsoft.EntityFrameworkCore;
using SCA.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Infrastrucuture.Data
{
    public class AudienciaContext : DbContext
    {

        public AudienciaContext(DbContextOptions<AudienciaContext> options) : base(options)
        {

        }

        public DbSet<Audiencia> Audiencias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Audiencia>().ToTable("Audiencia");
        }


    }
}
