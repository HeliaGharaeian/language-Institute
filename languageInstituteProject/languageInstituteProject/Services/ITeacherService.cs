using languageInstituteProject.Models;

namespace languageInstituteProject.Services
{
    public interface ITeacherService
    {
        int Add(Teacher teacher);
        int Delete(int Id);
        Student Find(int Id);
        List<Student> List();
        Student Edit(Teacher teacher);
        List<Student> Search(string Name);
    }
}
