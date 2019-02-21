namespace websitecsharp.domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newfields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.people", "phoneNumber", c => c.String());
            AddColumn("dbo.people", "personGender", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.people", "personGender");
            DropColumn("dbo.people", "phoneNumber");
        }
    }
}
