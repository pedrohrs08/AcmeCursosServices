namespace AcmeCursosServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inscricao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inscricao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EstudanteId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                        DataInscricao = c.DateTime(nullable: false)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Estudantes", t => t.EstudanteId, cascadeDelete: true)
                .Index(t => t.EstudanteId)
                .Index(t => t.CursoId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inscricao", "EstudanteId", "dbo.Estudantes");
            DropForeignKey("dbo.Inscricao", "CursoId", "dbo.Curso");
            DropIndex("dbo.Inscricao", new[] { "CursoId" });
            DropIndex("dbo.Inscricao", new[] { "EstudanteId" });
            DropTable("dbo.Inscricao");
        }
    }
}
