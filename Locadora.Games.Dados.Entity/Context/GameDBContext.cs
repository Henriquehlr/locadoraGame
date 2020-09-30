using Locadora.Games.Dados.Entity.TypeConfiguration;
using Locadora.Games.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Games.Dados.Entity.Context
{
    public class GameDBContext : DbContext
    {
        public DbSet<TipoGame> TiposGames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TipoGameTypeConfiguration());
        }
    }
}
