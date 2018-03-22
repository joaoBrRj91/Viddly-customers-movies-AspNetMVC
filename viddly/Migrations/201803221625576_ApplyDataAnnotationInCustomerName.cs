namespace viddly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyDataAnnotationInCustomerName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Nome", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Nome", c => c.String());
        }
    }
}
