namespace PassionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class meals1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        MealID = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                        Mealtype = c.String(),
                    })
                .PrimaryKey(t => t.MealID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Meals");
        }
    }
}
