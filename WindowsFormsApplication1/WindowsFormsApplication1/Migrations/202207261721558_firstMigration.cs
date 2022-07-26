namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyBillItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BuyBillId = c.Int(nullable: false),
                        ItemDescription = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BuyBills", t => t.BuyBillId, cascadeDelete: true)
                .Index(t => t.BuyBillId);
            
            CreateTable(
                "dbo.BuyBills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TraderId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Traders", t => t.TraderId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.TraderId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Traders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ActivityType = c.String(),
                        Debit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HiredDate = c.DateTime(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Captains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        EnteredPrice = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        OrderType = c.String(),
                        IsPayed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        ShiftType = c.String(),
                        MoneyEarned = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.WalletTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionType = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        Amount = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        CurrentState = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WalletTransactions", "UserId", "dbo.Users");
            DropForeignKey("dbo.Shifts", "UserId", "dbo.Users");
            DropForeignKey("dbo.OrderProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.OrderProducts", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.BuyBills", "UserId", "dbo.Users");
            DropForeignKey("dbo.BuyBills", "TraderId", "dbo.Traders");
            DropForeignKey("dbo.BuyBillItems", "BuyBillId", "dbo.BuyBills");
            DropIndex("dbo.WalletTransactions", new[] { "UserId" });
            DropIndex("dbo.Shifts", new[] { "UserId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.OrderProducts", new[] { "OrderId" });
            DropIndex("dbo.OrderProducts", new[] { "ProductId" });
            DropIndex("dbo.BuyBills", new[] { "UserId" });
            DropIndex("dbo.BuyBills", new[] { "TraderId" });
            DropIndex("dbo.BuyBillItems", new[] { "BuyBillId" });
            DropTable("dbo.WalletTransactions");
            DropTable("dbo.Shifts");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderProducts");
            DropTable("dbo.Captains");
            DropTable("dbo.Users");
            DropTable("dbo.Traders");
            DropTable("dbo.BuyBills");
            DropTable("dbo.BuyBillItems");
        }
    }
}
