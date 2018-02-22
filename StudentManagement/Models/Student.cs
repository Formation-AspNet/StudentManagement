using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Range(5, 50)]
        public int Age { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}