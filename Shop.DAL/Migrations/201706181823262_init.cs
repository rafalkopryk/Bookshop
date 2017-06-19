namespace Shop.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Price = c.Single(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        SuperBargain = c.Boolean(nullable: false),
                        PublisherId = c.Long(nullable: false),
                        AuthorId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Publishers", t => t.PublisherId, cascadeDelete: true)
                .Index(t => t.PublisherId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        PublisherId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PublisherId);
            
            CreateTable(
                "dbo.Carriers",
                c => new
                    {
                        CarrierId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CarrierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropIndex("dbo.Books", new[] { "PublisherId" });
            DropTable("dbo.Carriers");
            DropTable("dbo.Publishers");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
