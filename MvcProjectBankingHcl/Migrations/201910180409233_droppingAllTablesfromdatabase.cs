namespace MvcProjectBankingHcl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droppingAllTablesfromdatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AccountDetails", "AccountHolderDetailsid", "dbo.AccountHolderDetails");
            DropForeignKey("dbo.Transactions", "AccountDetails_AccountDetailsId", "dbo.AccountDetails");
            DropIndex("dbo.AccountDetails", new[] { "AccountHolderDetailsid" });
            DropIndex("dbo.Transactions", new[] { "AccountDetails_AccountDetailsId" });
            DropTable("dbo.AccountDetails");
            DropTable("dbo.AccountHolderDetails");
            DropTable("dbo.Transactions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        TransactionTimeAndDate = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                        TransactionType = c.String(),
                        AccountDetailsId = c.Int(),
                        AccountDetails_AccountDetailsId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TransactionId);
            
            CreateTable(
                "dbo.AccountHolderDetails",
                c => new
                    {
                        AccountHolderDetailsid = c.Int(nullable: false, identity: true),
                        AccountHolderName = c.String(),
                        City = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        MobileNumber = c.String(),
                        AlternateMobileNumber = c.String(),
                        EmailId = c.String(),
                        MyProperty = c.Int(nullable: false),
                        Address = c.String(),
                        IdProofs = c.Binary(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.AccountHolderDetailsid);
            
            CreateTable(
                "dbo.AccountDetails",
                c => new
                    {
                        AccountDetailsId = c.String(nullable: false, maxLength: 128),
                        AccountNumber = c.String(),
                        IFSCCode = c.String(),
                        BankBranch = c.String(),
                        AccountType = c.Int(nullable: false),
                        AccountHolderDetailsid = c.Int(),
                    })
                .PrimaryKey(t => t.AccountDetailsId);
            
            CreateIndex("dbo.Transactions", "AccountDetails_AccountDetailsId");
            CreateIndex("dbo.AccountDetails", "AccountHolderDetailsid");
            AddForeignKey("dbo.Transactions", "AccountDetails_AccountDetailsId", "dbo.AccountDetails", "AccountDetailsId");
            AddForeignKey("dbo.AccountDetails", "AccountHolderDetailsid", "dbo.AccountHolderDetails", "AccountHolderDetailsid");
        }
    }
}
