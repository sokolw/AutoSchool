﻿namespace AutoSchool.Models.Tables
{
    public class Teacher
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
