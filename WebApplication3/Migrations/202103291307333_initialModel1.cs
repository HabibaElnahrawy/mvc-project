namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "CatId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CatId" });
            RenameColumn(table: "dbo.Products", name: "CatId", newName: "Category_CatId");
            AddColumn("dbo.Products", "Category", c => c.String());
            AlterColumn("dbo.Products", "Category_CatId", c => c.Int());
            CreateIndex("dbo.Products", "Category_CatId");
            AddForeignKey("dbo.Products", "Category_CatId", "dbo.Categories", "CatId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category_CatId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_CatId" });
            AlterColumn("dbo.Products", "Category_CatId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Category");
            RenameColumn(table: "dbo.Products", name: "Category_CatId", newName: "CatId");
            CreateIndex("dbo.Products", "CatId");
            AddForeignKey("dbo.Products", "CatId", "dbo.Categories", "CatId", cascadeDelete: true);
        }
    }
}
