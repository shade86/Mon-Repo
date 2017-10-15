namespace Mon_Repo.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDbModels",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        BuyDate = c.String(),
                        PurchaseDbModel_PurchaseId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.PurchaseDbModels", t => t.PurchaseDbModel_PurchaseId)
                .Index(t => t.PurchaseDbModel_PurchaseId);
            
            CreateTable(
                "dbo.PurchaseDbModels",
                c => new
                    {
                        PurchaseId = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.PurchaseId)
                .ForeignKey("dbo.UserDbModels", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.UserDbModels",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Money = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseDbModels", "User_UserId", "dbo.UserDbModels");
            DropForeignKey("dbo.ProductDbModels", "PurchaseDbModel_PurchaseId", "dbo.PurchaseDbModels");
            DropIndex("dbo.PurchaseDbModels", new[] { "User_UserId" });
            DropIndex("dbo.ProductDbModels", new[] { "PurchaseDbModel_PurchaseId" });
            DropTable("dbo.UserDbModels");
            DropTable("dbo.PurchaseDbModels");
            DropTable("dbo.ProductDbModels");
        }
    }
}
