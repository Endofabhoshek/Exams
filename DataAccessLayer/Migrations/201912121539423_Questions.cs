namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Questions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActualQuestion = c.String(),
                        QuestionPaper_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.QuestionPapers", t => t.QuestionPaper_Id)
                .Index(t => t.QuestionPaper_Id);
            
            CreateTable(
                "dbo.QuestionPapers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "QuestionPaper_Id", "dbo.QuestionPapers");
            DropIndex("dbo.Questions", new[] { "QuestionPaper_Id" });
            DropTable("dbo.QuestionPapers");
            DropTable("dbo.Questions");
        }
    }
}
