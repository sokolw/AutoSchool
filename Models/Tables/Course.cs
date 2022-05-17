using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoSchool.Models.Tables
{
    public class Course
    {
        [MaxLength(450)]
        public string Id { get; set; }
        public string Description { get; set; }


        [MaxLength(450)]
        public string TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public IEnumerable<Student> Students { get; set; } 
    }
}
