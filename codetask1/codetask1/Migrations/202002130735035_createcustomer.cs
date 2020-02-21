namespace codetask1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createcustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.products",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        Pname = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Cid = c.Int(),
                        Cname = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        customer_Pid = c.Int(),
                    })
                .PrimaryKey(t => t.Pid)
                .ForeignKey("dbo.products", t => t.customer_Pid)
                .Index(t => t.customer_Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "customer_Pid", "dbo.products");
            DropIndex("dbo.products", new[] { "customer_Pid" });
            DropTable("dbo.products");
        }
    }
}
