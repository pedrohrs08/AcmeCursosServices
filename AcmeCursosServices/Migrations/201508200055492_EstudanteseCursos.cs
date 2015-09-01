namespace AcmeCursosServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstudanteseCursos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250),
                        Descricao = c.String(nullable: false),
                        DataLimiteInscricao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Estudantes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Sobrenome = c.String(nullable: false),
                        DataMatricula = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Estudantes");
            DropTable("dbo.Curso");
        }
    }
}
