namespace AcmeCursosServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelacaoProfessorCurso
        : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProfessorCursoes",
                c => new
                    {
                        Professor_Id = c.Int(nullable: false),
                        Curso_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Professor_Id, t.Curso_Id })
                .ForeignKey("dbo.Professor", t => t.Professor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Curso", t => t.Curso_Id, cascadeDelete: true)
                .Index(t => t.Professor_Id)
                .Index(t => t.Curso_Id);
            
        }
        
        public override void Down()
        {

            DropForeignKey("dbo.ProfessorCursoes", "Curso_Id", "dbo.Curso");
            DropForeignKey("dbo.ProfessorCursoes", "Professor_Id", "dbo.Professor");
            DropIndex("dbo.ProfessorCursoes", new[] { "Curso_Id" });
            DropIndex("dbo.ProfessorCursoes", new[] { "Professor_Id" });
            DropTable("dbo.ProfessorCursoes");
        }
    }
}
