namespace viddly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths,DiscountRate) VALUES(10, 6, 0)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths,DiscountRate) VALUES(20, 12, 5)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths,DiscountRate) VALUES(25, 18, 5)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths,DiscountRate) VALUES(10, 24, 10)");
        }
        
        public override void Down()
        {
        }
    }
}
