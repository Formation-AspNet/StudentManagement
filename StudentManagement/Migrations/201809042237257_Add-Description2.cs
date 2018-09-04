namespace StudentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescription2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Description2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Groups", "Description2");
        }
    }
}
