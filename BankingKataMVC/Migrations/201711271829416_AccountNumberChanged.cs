namespace BankingKataMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountNumberChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String(nullable: false));
        }
    }
}
