namespace MvcProjectBankingHcl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedreferncetabletoTransactionsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "AccountDetailsId", c => c.Int());
            AddColumn("dbo.Transactions", "AccountDetails_AccountDetailsId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Transactions", "AccountDetails_AccountDetailsId");
            AddForeignKey("dbo.Transactions", "AccountDetails_AccountDetailsId", "dbo.AccountDetails", "AccountDetailsId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "AccountDetails_AccountDetailsId", "dbo.AccountDetails");
            DropIndex("dbo.Transactions", new[] { "AccountDetails_AccountDetailsId" });
            DropColumn("dbo.Transactions", "AccountDetails_AccountDetailsId");
            DropColumn("dbo.Transactions", "AccountDetailsId");
        }
    }
}
