namespace CodeFirstDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogModels",
                c => new
                    {
                        BlogModelId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BlogModelId);
            
            CreateTable(
                "dbo.PostModels",
                c => new
                    {
                        PostModelId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        BlogModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostModelId)
                .ForeignKey("dbo.BlogModels", t => t.BlogModelId, cascadeDelete: true)
                .Index(t => t.BlogModelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostModels", "BlogModelId", "dbo.BlogModels");
            DropIndex("dbo.PostModels", new[] { "BlogModelId" });
            DropTable("dbo.PostModels");
            DropTable("dbo.BlogModels");
        }
    }
}
