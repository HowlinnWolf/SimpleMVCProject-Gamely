namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeNamesLocalization : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET TypeName = N'������ �� �����' WHERE Id = '1'");
            Sql("UPDATE MembershipTypes SET TypeName = N'�����������' WHERE Id = '2'");
            Sql("UPDATE MembershipTypes SET TypeName = N'��������������' WHERE Id = '3'");
            Sql("UPDATE MembershipTypes SET TypeName = N'���������' WHERE Id = '4'");
        }
        
        public override void Down()
        {
        }
    }
}
