namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'293ed3de-5cc4-4981-b13b-4adf3bfda109', N'admin@vidly.com', 0, N'ACsPF64z3w7XgOaNUOKJV4AnYIXrBFE0Z0qHjwDUhggO1bl5mARqR7h+yjPaWidVTw==', N'274bfc8a-53b8-4f16-b714-d182aa98bcff', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'70cd21ff-8e2c-4638-a4e1-94180462d774', N'guest@vidly.com', 0, N'ADIn98bwjCHlCW23Xtabx28CLprNDSs2D3N+vWvIWRUBVrU+cyKl5Kf5iW3kpEA8fA==', N'456601c7-36df-479a-8e1f-b151d6d8f453', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd889a4eb-2cda-4f9c-81f3-1827d55ee184', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'293ed3de-5cc4-4981-b13b-4adf3bfda109', N'd889a4eb-2cda-4f9c-81f3-1827d55ee184')
");
        }
        
        public override void Down()
        {
        }
    }
}
