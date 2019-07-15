namespace SugarLevelTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SugarLevels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Value = c.Single(nullable: false),
                        Description = c.String(nullable: false),
                        MeasuredAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SugarLevels");
        }
    }
}
