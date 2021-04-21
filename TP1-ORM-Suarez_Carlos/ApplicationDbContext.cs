using Microsoft.EntityFrameworkCore;
using TP1_ORM_Suarez_Carlos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_ORM_Suarez_Carlos
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Comanda> Comandas {get; set;}
        public DbSet<ComandaMercaderia> ComandaMercaderias { get; set; }
        public DbSet<FormaEntrega> FormaEntregas { get; set; }
        public DbSet<Mercaderia> Mercaderias { get; set; }
        public DbSet<TipoMercaderia> TipoMercaderias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = localhost; Database = ORM_MenuRestaurant ; Trusted_Connection = True; MultipleActiveResultSets = True");
        }

    }
}
