using languageInstituteProject.Data;
using languageInstituteProject.Models;

namespace languageInstituteProject.Services
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public int ClassId { get; set; }
    }
}
