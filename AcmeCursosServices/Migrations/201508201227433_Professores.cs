namespace AcmeCursosServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Professores : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Professor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Sobrenome = c.String(nullable: false),
                        Titulacao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Professor");
        }
    }
}
