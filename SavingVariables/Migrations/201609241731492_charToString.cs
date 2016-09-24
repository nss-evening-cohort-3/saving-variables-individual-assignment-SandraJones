namespace SavingVariables.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class charToString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Constants", "Key", c => c.String(nullable: false, maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Constants", "Key");
        }
    }
}
