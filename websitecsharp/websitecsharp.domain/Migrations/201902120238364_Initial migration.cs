namespace websitecsharp.domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.scoredatas",
                c => new
                    {
                        highScoreId = c.Guid(nullable: false),
                        personId = c.Guid(nullable: false),
                        score = c.Int(nullable: false),
                        dateAttained = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.highScoreId);
            
            CreateTable(
                "dbo.people",
                c => new
                    {
                        personID = c.Guid(nullable: false),
                        firstName = c.String(),
                        lastName = c.String(),
                        dateCreated = c.DateTime(nullable: false),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.personID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.people");
            DropTable("dbo.scoredatas");
        }
    }
}
