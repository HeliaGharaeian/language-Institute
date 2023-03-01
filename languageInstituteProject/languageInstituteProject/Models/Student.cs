namespace languageInstituteProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        //public IEnumerable<Class> Classes { get; set; }
        public Class Class { get; set;}
        public int ClassId { get; set; }
    }
}
