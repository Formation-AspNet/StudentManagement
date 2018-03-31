using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    public class Student
    {
        #region Properties
        public int StudentId { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Range(5, 50)]
        public int Age { get; set; }
        #endregion

        #region Navigation Objects
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        [NotMapped]
        public string TeamsDescription
        {
            get
            {

                string description = "";

                // Solution 1 

                //if (this.Teams != null)
                //    foreach (var item in this.Teams)
                //    {
                //        description += item.TeamName + ",";
                //    }

                // Solution 2
                description = String.Join(",", this.Teams.Select(t => t.TeamName));
                return description;
            }
          
        }
        #endregion
    }
}