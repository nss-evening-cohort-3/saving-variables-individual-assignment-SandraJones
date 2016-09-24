namespace SavingVariables.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialState : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Constants",
                c => new
                    {
                        ConstantId = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ConstantId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Constants");
        }
    }
}
