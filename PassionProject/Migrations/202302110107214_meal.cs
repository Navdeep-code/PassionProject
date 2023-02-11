namespace PassionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class meal : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Meals", "Day");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Meals", "Day", c => c.String());
        }
    }
}
