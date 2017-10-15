namespace Mon_Repo.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductDbModels", "PurchaseDbModel_PurchaseId", "dbo.PurchaseDbModels");
            DropForeignKey("dbo.PurchaseDbModels", "User_UserId", "dbo.UserDbModels");
            DropIndex("dbo.ProductDbModels", new[] { "PurchaseDbModel_PurchaseId" });
            DropIndex("dbo.PurchaseDbModels", new[] { "User_UserId" });
            DropColumn("dbo.ProductDbModels", "BuyDate");
            DropColumn("dbo.ProductDbModels", "PurchaseDbModel_PurchaseId");
            DropTable("dbo.PurchaseDbModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PurchaseDbModels",
                c => new
                    {
                        PurchaseId = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.PurchaseId);
            
            AddColumn("dbo.ProductDbModels", "PurchaseDbModel_PurchaseId", c => c.Int());
            AddColumn("dbo.ProductDbModels", "BuyDate", c => c.String());
            CreateIndex("dbo.PurchaseDbModels", "User_UserId");
            CreateIndex("dbo.ProductDbModels", "PurchaseDbModel_PurchaseId");
            AddForeignKey("dbo.PurchaseDbModels", "User_UserId", "dbo.UserDbModels", "UserId");
            AddForeignKey("dbo.ProductDbModels", "PurchaseDbModel_PurchaseId", "dbo.PurchaseDbModels", "PurchaseId");
        }
    }
}
