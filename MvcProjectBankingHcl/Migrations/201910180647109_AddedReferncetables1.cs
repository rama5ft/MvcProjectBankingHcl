namespace MvcProjectBankingHcl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedReferncetables1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountDetails", "AccountHolderDetailsId", c => c.Int());
            CreateIndex("dbo.AccountDetails", "AccountHolderDetailsId");
            AddForeignKey("dbo.AccountDetails", "AccountHolderDetailsId", "dbo.AccountHolderDetails", "AccountHolderDetailsId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountDetails", "AccountHolderDetailsId", "dbo.AccountHolderDetails");
            DropIndex("dbo.AccountDetails", new[] { "AccountHolderDetailsId" });
            DropColumn("dbo.AccountDetails", "AccountHolderDetailsId");
        }
    }
}
