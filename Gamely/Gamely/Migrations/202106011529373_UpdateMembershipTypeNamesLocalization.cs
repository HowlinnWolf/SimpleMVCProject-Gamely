namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeNamesLocalization : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET TypeName = N'ќплата по факту' WHERE Id = '1'");
            Sql("UPDATE MembershipTypes SET TypeName = N'≈жемес€чна€' WHERE Id = '2'");
            Sql("UPDATE MembershipTypes SET TypeName = N'≈жеквартальна€' WHERE Id = '3'");
            Sql("UPDATE MembershipTypes SET TypeName = N'≈жегодна€' WHERE Id = '4'");
        }
        
        public override void Down()
        {
        }
    }
}
