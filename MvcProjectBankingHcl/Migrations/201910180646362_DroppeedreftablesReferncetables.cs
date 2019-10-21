namespace MvcProjectBankingHcl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DroppeedreftablesReferncetables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AccountDetails", "AccountHolderDetailsid", "dbo.AccountHolderDetails");
            DropIndex("dbo.AccountDetails", new[] { "AccountHolderDetailsid" });
            DropColumn("dbo.AccountDetails", "AccountHolderDetailsid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AccountDetails", "AccountHolderDetailsid", c => c.Int());
            CreateIndex("dbo.AccountDetails", "AccountHolderDetailsid");
            AddForeignKey("dbo.AccountDetails", "AccountHolderDetailsid", "dbo.AccountHolderDetails", "AccountHolderDetailsId");
        }
    }
}
