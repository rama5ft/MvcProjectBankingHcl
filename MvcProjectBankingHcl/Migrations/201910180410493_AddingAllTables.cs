namespace MvcProjectBankingHcl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountDetails",
                c => new
                    {
                        AccountDetailsId = c.String(nullable: false, maxLength: 128),
                        AccountNumber = c.String(),
                        IFSCCode = c.String(),
                        BankBranch = c.String(),
                        AccountType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccountDetailsId);
            
            CreateTable(
                "dbo.AccountHolderDetails",
                c => new
                    {
                        AccountHolderDetailsId = c.Int(nullable: false, identity: true),
                        AccountHolderName = c.String(),
                        City = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        MobileNumber = c.String(),
                        AlternateMobileNumber = c.String(),
                        EmailId = c.String(),
                        Address = c.String(),
                        IdProofs = c.Binary(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.AccountHolderDetailsId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        TransactionTimeAndDate = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                        TransactionType = c.String(),
                    })
                .PrimaryKey(t => t.TransactionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transactions");
            DropTable("dbo.AccountHolderDetails");
            DropTable("dbo.AccountDetails");
        }
    }
}
