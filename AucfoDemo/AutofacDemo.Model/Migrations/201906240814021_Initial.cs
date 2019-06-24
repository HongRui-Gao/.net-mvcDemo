namespace AutofacDemo.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Books_Title = c.String(nullable: false, maxLength: 255, unicode: false),
                        Books_Author = c.String(nullable: false, maxLength: 255, unicode: false),
                        Books_Press = c.String(nullable: false, maxLength: 255, unicode: false),
                        Books_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Books_Counts = c.Int(nullable: false),
                        Books_Bcid = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BooksCategories", t => t.Books_Bcid, cascadeDelete: true)
                .Index(t => t.Books_Bcid);
            
            CreateTable(
                "dbo.BooksCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BooksCategory_Title = c.String(nullable: false, maxLength: 255, unicode: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Books_Bcid", "dbo.BooksCategories");
            DropIndex("dbo.Books", new[] { "Books_Bcid" });
            DropTable("dbo.BooksCategories");
            DropTable("dbo.Books");
        }
    }
}
