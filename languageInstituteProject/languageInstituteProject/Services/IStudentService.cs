using languageInstituteProject.Data;

namespace languageInstituteProject.Services
{
    public interface IStudentService
    {
        int Add(StudentDto student);
        int Delete(int Id);
        StudentDto Find(int Id);
        List<StudentDto> List();
        Student Edit(StudentDto student);
        List<StudentDto> Search(string Name);
    }
}

    
