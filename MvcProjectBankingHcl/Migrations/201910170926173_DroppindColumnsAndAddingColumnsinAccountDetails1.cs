namespace MvcProjectBankingHcl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DroppindColumnsAndAddingColumnsinAccountDetails1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountHolderDetails", "AccountHolderName", c => c.String());
            DropColumn("dbo.AccountHolderDetails", "FirstName");
            DropColumn("dbo.AccountHolderDetails", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AccountHolderDetails", "LastName", c => c.String());
            AddColumn("dbo.AccountHolderDetails", "FirstName", c => c.String());
            DropColumn("dbo.AccountHolderDetails", "AccountHolderName");
        }
    }
}
