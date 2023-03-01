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

        public Class Class { get; set; }
    }

    public class Student : IStudentService
    {
        private readonly DatabaseContext _context;
        public Student(DatabaseContext context)
        {
            _context = context;
        }

        public int Add(StudentDto student)
        {
            Models.Student entity = new Models.Student
            {
                Email = student.Email,
                Class = student.Class,
                Gender= student.Gender,
                Name= student.Name,
                PhoneNumber= student.PhoneNumber,
            };
            _context.Add(entity);
            _context.SaveChanges();
            return entity.Id;   
        }


        public int Delete(int Id)
        {
            _context.students.Remove(new Models.Student { Id = Id });
            return _context.SaveChanges();
        }


        public Student Edit(StudentDto student)
        {
            var entity = _context.students.Find(student.Id);
            entity
        }

        public Student Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Student> List()
        {
            throw new NotImplementedException();
        }

        public List<Student> Search(string Name)
        {
            throw new NotImplementedException();
        }

        StudentDto IStudentService.Find(int Id)
        {
            throw new NotImplementedException();
        }

        List<StudentDto> IStudentService.List()
        {
            throw new NotImplementedException();
        }

        List<StudentDto> IStudentService.Search(string Name)
        {
            throw new NotImplementedException();
        }
    }

}
