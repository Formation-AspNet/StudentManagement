namespace StudentManagement.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentContext : DbContext
    {

        public StudentContext()
            : base("name=StudentContext")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
    }


}

