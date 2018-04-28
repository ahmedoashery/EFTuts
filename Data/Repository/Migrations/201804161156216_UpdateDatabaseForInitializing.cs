namespace EFTuts.Data.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseForInitializing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Country", c => c.String());
            AddColumn("dbo.Customers", "Region", c => c.String());
            AddColumn("dbo.Customers", "City", c => c.String());
            AddColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Fax", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Name", c => c.String());
            AddColumn("dbo.Products", "Barcode", c => c.String());
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryID");
            AddForeignKey("dbo.Products", "CategoryID", "dbo.Categories", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropColumn("dbo.Products", "CategoryID");
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.Products", "Barcode");
            DropColumn("dbo.Products", "Name");
            DropColumn("dbo.Customers", "Fax");
            DropColumn("dbo.Customers", "Phone");
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "Region");
            DropColumn("dbo.Customers", "Country");
        }
    }
}
