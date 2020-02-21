namespace codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createcustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        Cname = c.String(nullable: false),
                        Caddress = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Cid);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Cid = c.Int(nullable: false),
                        Pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.customers", t => t.Cid, cascadeDelete: true)
                .ForeignKey("dbo.products", t => t.Pid, cascadeDelete: true)
                .Index(t => t.Cid)
                .Index(t => t.Pid);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        pname = c.String(maxLength: 250),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "Pid", "dbo.products");
            DropForeignKey("dbo.Purchases", "Cid", "dbo.customers");
            DropIndex("dbo.Purchases", new[] { "Pid" });
            DropIndex("dbo.Purchases", new[] { "Cid" });
            DropTable("dbo.products");
            DropTable("dbo.Purchases");
            DropTable("dbo.customers");
        }
    }
}
