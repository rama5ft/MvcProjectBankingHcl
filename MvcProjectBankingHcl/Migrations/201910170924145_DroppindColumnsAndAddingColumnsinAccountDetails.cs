namespace MvcProjectBankingHcl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DroppindColumnsAndAddingColumnsinAccountDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountDetails", "AccountType", c => c.Int(nullable: false));
            DropColumn("dbo.AccountDetails", "AccountHolderName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AccountDetails", "AccountHolderName", c => c.String());
            DropColumn("dbo.AccountDetails", "AccountType");
        }
    }
}
