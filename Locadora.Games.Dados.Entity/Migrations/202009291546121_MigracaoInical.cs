namespace Locadora.Games.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInical : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoGame",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Categoria = c.String(nullable: false, maxLength: 100),
                        Grafico = c.String(nullable: false, maxLength: 50),
                        Classificacao = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(nullable: false, maxLength: 1000),
                        Ano = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoGame");
        }
    }
}
