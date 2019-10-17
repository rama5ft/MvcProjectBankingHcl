namespace MvcProjectBankingHcl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedTableforAccountHolderDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountHolderDetails",
                c => new
                    {
                        AccountHolderDetailsid = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountHolderDetails");
        }
    }
}
