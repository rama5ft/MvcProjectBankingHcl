namespace MvcProjectBankingHcl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedreferncetabletoaccountdetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountDetails", "AccountHolderDetailsid", c => c.Int());
            CreateIndex("dbo.AccountDetails", "AccountHolderDetailsid");
            AddForeignKey("dbo.AccountDetails", "AccountHolderDetailsid", "dbo.AccountHolderDetails", "AccountHolderDetailsid");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountDetails", "AccountHolderDetailsid", "dbo.AccountHolderDetails");
            DropIndex("dbo.AccountDetails", new[] { "AccountHolderDetailsid" });
            DropColumn("dbo.AccountDetails", "AccountHolderDetailsid");
        }
    }
}
