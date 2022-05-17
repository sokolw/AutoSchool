using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoSchool.Models.Tables
{
    public class Student
    {
        [Key]
        [MaxLength(450)]
        public string UserId { get; set; }
        public User User { get; set; }

        public IEnumerable<Course> Courses { get; set; } 
    }
}
