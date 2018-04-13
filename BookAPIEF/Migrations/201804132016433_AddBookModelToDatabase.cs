namespace BookAPIEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookModelToDatabase : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Age", c => c.Int(nullable: false));
        }
    }
}
