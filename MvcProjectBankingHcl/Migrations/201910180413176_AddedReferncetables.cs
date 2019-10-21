namespace MvcProjectBankingHcl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedReferncetables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountDetails", "AccountHolderDetailsid", c => c.Int());
            AddColumn("dbo.Transactions", "AccountDetailsId", c => c.Int());
            AddColumn("dbo.Transactions", "AccountDetails_AccountDetailsId", c => c.String(maxLength: 128));
            CreateIndex("dbo.AccountDetails", "AccountHolderDetailsid");
            CreateIndex("dbo.Transactions", "AccountDetails_AccountDetailsId");
            AddForeignKey("dbo.AccountDetails", "AccountHolderDetailsid", "dbo.AccountHolderDetails", "AccountHolderDetailsId");
            AddForeignKey("dbo.Transactions", "AccountDetails_AccountDetailsId", "dbo.AccountDetails", "AccountDetailsId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "AccountDetails_AccountDetailsId", "dbo.AccountDetails");
            DropForeignKey("dbo.AccountDetails", "AccountHolderDetailsid", "dbo.AccountHolderDetails");
            DropIndex("dbo.Transactions", new[] { "AccountDetails_AccountDetailsId" });
            DropIndex("dbo.AccountDetails", new[] { "AccountHolderDetailsid" });
            DropColumn("dbo.Transactions", "AccountDetails_AccountDetailsId");
            DropColumn("dbo.Transactions", "AccountDetailsId");
            DropColumn("dbo.AccountDetails", "AccountHolderDetailsid");
        }
    }
}
