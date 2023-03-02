using languageInstituteProject.Models;

namespace languageInstituteProject.Dtos
{
    public class ClassDto
    {
        public int Id { get; set; }
        public Teacher Teacher { get; set; }
        //public IEnumerable<Student> Students { get; set; }
    }
}
