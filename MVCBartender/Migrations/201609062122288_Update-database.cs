namespace MVCBartender.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        CartID = c.String(),
                        CocktailID = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.Cocktails", t => t.CocktailID, cascadeDelete: true)
                .Index(t => t.CocktailID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        CocktailID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Cocktails", t => t.CocktailID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.CocktailID);
            
            AddColumn("dbo.Orders", "FirstName", c => c.String());
            AddColumn("dbo.Orders", "LastName", c => c.String());
            AddColumn("dbo.Orders", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "CocktailID", "dbo.Cocktails");
            DropForeignKey("dbo.Carts", "CocktailID", "dbo.Cocktails");
            DropIndex("dbo.OrderDetails", new[] { "CocktailID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Carts", new[] { "CocktailID" });
            DropColumn("dbo.Orders", "Total");
            DropColumn("dbo.Orders", "LastName");
            DropColumn("dbo.Orders", "FirstName");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Carts");
        }
    }
}
