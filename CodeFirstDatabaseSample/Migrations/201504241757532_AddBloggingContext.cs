namespace CodeFirstDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBloggingContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogViews",
                c => new
                    {
                        BlogViewId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BlogViewId);
            
            CreateTable(
                "dbo.PostViews",
                c => new
                    {
                        PostViewId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        BlogView_BlogViewId = c.Int(),
                    })
                .PrimaryKey(t => t.PostViewId)
                .ForeignKey("dbo.BlogViews", t => t.BlogView_BlogViewId)
                .Index(t => t.BlogView_BlogViewId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostViews", "BlogView_BlogViewId", "dbo.BlogViews");
            DropIndex("dbo.PostViews", new[] { "BlogView_BlogViewId" });
            DropTable("dbo.PostViews");
            DropTable("dbo.BlogViews");
        }
    }
}
