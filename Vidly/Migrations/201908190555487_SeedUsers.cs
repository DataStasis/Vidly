namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6fcf6336-139a-4448-9fdb-62b5b936a9dd', N'guest@vidly.com', 0, N'ABA0K2ou1NKBwuDjZUepBNQNGYV1MYq+eGryFWNf+VdJz3lLNGdY5lvoGh1KbTJseQ==', N'957d711c-1275-4686-977e-cabcaf73acc2', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c573eefa-35cd-482f-9450-8c5d9144f7fb', N'admin@vidly.com', 0, N'AOUN4qTgczm9fiQNdVqfoXNKPUfzqG/2fHO3UOU7FCpDnbSU9OOKIxuF57/H5wPrXA==', N'9c8d8ca8-8929-466d-9beb-5c720f166afb', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f1f05cee-d571-4edb-9e71-468b8b62b494', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c573eefa-35cd-482f-9450-8c5d9144f7fb', N'f1f05cee-d571-4edb-9e71-468b8b62b494')
");
        }
        
        public override void Down()
        {
        }
    }
}
