namespace EF6CodeFirst.DAL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INITIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Dbo.MeetingMembers",
                c => new
                    {
                        MemberId = c.Int(nullable: false),
                        MeetingId = c.Int(nullable: false),
                        IsAttending = c.Boolean(nullable: false),
                        CreationDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.MemberId, t.MeetingId })
                .ForeignKey("Dbo.Meetings", t => t.MeetingId, cascadeDelete: true)
                .ForeignKey("Dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId)
                .Index(t => t.MeetingId);
            
            CreateTable(
                "Dbo.Meetings",
                c => new
                    {
                        MeetingId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.MeetingId);
            
            CreateTable(
                "Dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.MemberId);
            
            CreateStoredProcedure(
                "Dbo.Member_Insert",
                p => new
                    {
                        FirstName = p.String(),
                        LastName = p.String(),
                        EmailAddress = p.String(),
                    },
                body:
                    @"INSERT [Dbo].[Members]([FirstName], [LastName], [EmailAddress])
                      VALUES (@FirstName, @LastName, @EmailAddress)
                      
                      DECLARE @MemberId int
                      SELECT @MemberId = [MemberId]
                      FROM [Dbo].[Members]
                      WHERE @@ROWCOUNT > 0 AND [MemberId] = scope_identity()
                      
                      SELECT t0.[MemberId]
                      FROM [Dbo].[Members] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[MemberId] = @MemberId"
            );
            
            CreateStoredProcedure(
                "Dbo.Member_Update",
                p => new
                    {
                        MemberId = p.Int(),
                        FirstName = p.String(),
                        LastName = p.String(),
                        EmailAddress = p.String(),
                    },
                body:
                    @"UPDATE [Dbo].[Members]
                      SET [FirstName] = @FirstName, [LastName] = @LastName, [EmailAddress] = @EmailAddress
                      WHERE ([MemberId] = @MemberId)"
            );
            
            CreateStoredProcedure(
                "Dbo.Member_Delete",
                p => new
                    {
                        MemberId = p.Int(),
                    },
                body:
                    @"DELETE [Dbo].[Members]
                      WHERE ([MemberId] = @MemberId)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("Dbo.Member_Delete");
            DropStoredProcedure("Dbo.Member_Update");
            DropStoredProcedure("Dbo.Member_Insert");
            DropForeignKey("Dbo.MeetingMembers", "MemberId", "Dbo.Members");
            DropForeignKey("Dbo.MeetingMembers", "MeetingId", "Dbo.Meetings");
            DropIndex("Dbo.MeetingMembers", new[] { "MeetingId" });
            DropIndex("Dbo.MeetingMembers", new[] { "MemberId" });
            DropTable("Dbo.Members");
            DropTable("Dbo.Meetings");
            DropTable("Dbo.MeetingMembers");
        }
    }
}
