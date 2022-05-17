using Microsoft.AspNetCore.Identity;

namespace AutoSchool.Models.Tables
{
    public class User : IdentityUser
    {
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
