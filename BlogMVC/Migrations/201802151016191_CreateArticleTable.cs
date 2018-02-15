namespace BlogMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateArticleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Title = c.String(nullable: false),
                        BodyText = c.String(nullable: false, unicode: false, storeType: "text"),
                        ArtistId = c.String(nullable: false),
                        Author_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "Author_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Articles", new[] { "Author_Id" });
            DropTable("dbo.Articles");
        }
    }
}
