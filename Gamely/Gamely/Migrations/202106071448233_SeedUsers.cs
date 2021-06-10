namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'45a6119a-3110-4e60-9c26-22797d2a9bfa', N'admin@gamely.com', 0, N'ANxFJPhl7zjdEmLxD5Lh68Q/NYNUSAsd5M06fd1BTzYPfhT7dOC69HivHspgZcGjFw==', N'56b0b9a5-3ed7-4a1f-bfda-5bddeb920dc6', NULL, 0, 0, NULL, 1, 0, N'admin@gamely.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fab7bcc5-4b4b-4477-a2ab-ee2378196b11', N'guest@gamely.com', 0, N'APAORvMJWtkeVUHquroWh63jRzng746tbFDKRQaVaSF/EB+1p+HlhGnX4z/0PxLzuQ==', N'6502c4a2-bd87-446a-8127-8925cf6226c6', NULL, 0, 0, NULL, 1, 0, N'guest@gamely.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'66415933-27e3-431f-af05-434b83a8f49b', N'CanManageGames')
            
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'45a6119a-3110-4e60-9c26-22797d2a9bfa', N'66415933-27e3-431f-af05-434b83a8f49b')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
