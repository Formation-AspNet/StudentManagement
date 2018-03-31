namespace StudentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTram : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.TeamStudents",
                c => new
                    {
                        Team_TeamId = c.Int(nullable: false),
                        Student_StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Team_TeamId, t.Student_StudentId })
                .ForeignKey("dbo.Teams", t => t.Team_TeamId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_StudentId, cascadeDelete: true)
                .Index(t => t.Team_TeamId)
                .Index(t => t.Student_StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamStudents", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.TeamStudents", "Team_TeamId", "dbo.Teams");
            DropIndex("dbo.TeamStudents", new[] { "Student_StudentId" });
            DropIndex("dbo.TeamStudents", new[] { "Team_TeamId" });
            DropTable("dbo.TeamStudents");
            DropTable("dbo.Teams");
        }
    }
}
