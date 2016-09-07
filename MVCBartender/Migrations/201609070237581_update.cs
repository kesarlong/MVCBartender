namespace MVCBartender.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoppingCartViewModels",
                c => new
                    {
                        CartID = c.Int(nullable: false, identity: true),
                        CartTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CartID);
            
            AddColumn("dbo.Carts", "ShoppingCartViewModel_CartID", c => c.Int());
            CreateIndex("dbo.Carts", "ShoppingCartViewModel_CartID");
            AddForeignKey("dbo.Carts", "ShoppingCartViewModel_CartID", "dbo.ShoppingCartViewModels", "CartID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "ShoppingCartViewModel_CartID", "dbo.ShoppingCartViewModels");
            DropIndex("dbo.Carts", new[] { "ShoppingCartViewModel_CartID" });
            DropColumn("dbo.Carts", "ShoppingCartViewModel_CartID");
            DropTable("dbo.ShoppingCartViewModels");
        }
    }
}
