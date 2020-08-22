namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdayOfCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("update Customers set birthday = '1992-10-12' where id = 6");
            Sql("update Customers set birthday = '1996-10-12' where id = 9");
        }
        
        public override void Down()
        {
        }
    }
}
