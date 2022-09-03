namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialModel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product1",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        ProductTitle = c.String(),
                        ProductPrice = c.String(),
                        ProductDescription = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product1");
        }
    }
}
