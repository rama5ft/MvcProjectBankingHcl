namespace MvcProjectBankingHcl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedTableforAccountDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountDetails",
                c => new
                    {
                        AccountDetailsId = c.String(nullable: false, maxLength: 128),
                        AccountHolderName = c.String(),
                        AccountNumber = c.String(),
                        IFSCCode = c.String(),
                        BankBranch = c.String(),
                    })
                .PrimaryKey(t => t.AccountDetailsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountDetails");
        }
    }
}
