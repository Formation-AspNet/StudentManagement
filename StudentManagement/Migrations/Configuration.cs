namespace StudentManagement.Migrations
{
    using StudentManagement.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentManagement.Models.EF.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StudentManagement.Models.EF.StudentContext";
        }

        protected override void Seed(StudentManagement.Models.EF.StudentContext context)
        {
           
            context.Groups.AddOrUpdate(
              p => p.GroupId,
              new Group { GroupId = 1 , Name = "Group 1" },
              new Group { GroupId = 2, Name = "Group 2" },
              new Group { GroupId = 3, Name = "Group 3" }
            );

            context.Students.AddOrUpdate(
             p => p.GroupId,
             new Student { StudentId = 1, Age = 22,GroupId = 1,StudentName = "Ali"},
             new Student { StudentId = 2, Age = 22, GroupId = 1, StudentName = "Karim" },
             new Student { StudentId = 3, Age = 22, GroupId = 1, StudentName = "Mouad" },
             new Student { StudentId = 4, Age = 22, GroupId = 2, StudentName = "Kamal" },
             new Student { StudentId = 5, Age = 23, GroupId = 2, StudentName = "Fatima" },
             new Student { StudentId = 6, Age = 23, GroupId = 2, StudentName = "Mouna" },
             new Student { StudentId = 7, Age = 23, GroupId = 2, StudentName = "Nabil" },
             new Student { StudentId = 8, Age = 23, GroupId = 2, StudentName = "Ikram" },
             new Student { StudentId = 9, Age = 23, GroupId = 3, StudentName = "Ali" },
             new Student { StudentId = 10, Age = 23, GroupId = 3, StudentName = "Mouad" }
           );



        }
    }
}
