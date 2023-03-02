using languageInstituteProject.Models;

namespace languageInstituteProject.Dtos
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Class classes { get; set; }
    }
}
