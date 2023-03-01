using languageInstituteProject.Models;

namespace languageInstituteProject.Services
{
    public interface IClassService
    {
        int Add(Class Class);
        int Delete(int Id);
        Student Find(int Id);
        List<Student> List();
        Student Edit(Class Class);
        List<Student> Search(int ClassNumber);
    }
}
