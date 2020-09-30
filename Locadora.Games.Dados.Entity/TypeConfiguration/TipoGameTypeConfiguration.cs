using Locadora.Games.Dominio;
using Locadora.Games.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Games.Dados.Entity.TypeConfiguration
{
    class TipoGameTypeConfiguration : LocadoraEntityAbstractConfig<TipoGame>
    {
        protected override void ConfigurarCamposTabela()
        {           
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Nome");
            Property(p => p.Categoria)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Categoria");
            Property(p => p.Grafico)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Grafico");
            Property(p => p.Classificacao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Classificacao");
            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(1000)
                .HasColumnName("Descricao");
            Property(p => p.Ano)
                .IsRequired()                
                .HasColumnName("Ano");
        }

        protected override void ConfigurarChaveEstrangeira()
        {
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("TipoGame");
        }
    }
}
