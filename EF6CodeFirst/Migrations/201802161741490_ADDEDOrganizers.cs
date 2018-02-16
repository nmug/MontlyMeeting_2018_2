namespace EF6CodeFirst.DAL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDEDOrganizers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Dbo.Organizers",
                c => new
                    {
                        OrganizerId = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrganizerId)
                .ForeignKey("Dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Dbo.Organizers", "MemberId", "Dbo.Members");
            DropIndex("Dbo.Organizers", new[] { "MemberId" });
            DropTable("Dbo.Organizers");
        }
    }
}
