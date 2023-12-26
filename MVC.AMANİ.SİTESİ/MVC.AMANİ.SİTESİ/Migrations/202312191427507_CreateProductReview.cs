namespace MVC.AMANİ.SİTESİ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateProductReview : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductReviews",
                c => new
                    {
                        ProductReviewId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Comment = c.String(),
                        Rating = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductReviewId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductReviews", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductReviews", new[] { "ProductId" });
            DropTable("dbo.ProductReviews");
        }
    }
}
