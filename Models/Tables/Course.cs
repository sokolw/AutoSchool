using System.Collections.Generic;

namespace AutoSchool.Models.Tables
{
    public class Course
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string Description { get; set; }

        public Teacher Teacher { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
