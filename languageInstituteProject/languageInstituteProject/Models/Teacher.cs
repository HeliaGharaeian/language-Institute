﻿namespace languageInstituteProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Class? classes { get; set; }
        public Class? ClassID { get; set; }


    }
}
