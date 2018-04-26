using Microsoft.EntityFrameworkCore;
using SCA.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Infrastrucuture.Data
{
    public class TipoContext : DbContext
    {

        public TipoContext(DbContextOptions<TipoContext> options) : base(options)
        {

        }

        public DbSet<Tipo> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tipo>().ToTable("Tipo");
        }


    }
}
