namespace StudentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student_Valisation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "StudentName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "StudentName", c => c.String());
        }
    }
}
