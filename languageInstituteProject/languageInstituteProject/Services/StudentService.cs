using languageInstituteProject.Data;
using languageInstituteProject.Models;

namespace languageInstituteProject.Services
{
    public class StudentService : IStudentService
    {
        private readonly DatabaseContext _context;
        public StudentService(DatabaseContext context)
        {
            _context = context;
        }

        public int Add(StudentDto student)
        {


            Models.Student entity = new Models.Student
            {
                Email = student.Email,
                Gender = student.Gender,
                Name = student.Name,
                PhoneNumber = student.PhoneNumber,
                ClassId = student.ClassId
            };

            _context.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }


        public int Delete(int Id)
        {
            _context.students.Remove(new Models.Student 
            { 
                Id = Id
            });
            return _context.SaveChanges();
        }


        public StudentDto Edit(StudentDto student)
        {
            var entity = _context.students.Find(student.Id);
            entity.ClassId = student.ClassId;
            entity.Gender = student.Gender;
            entity.Name = student.Name;
            entity.PhoneNumber = student.PhoneNumber;
            entity.Email = student.Email;
            _context.SaveChanges();
            return student;

        }
        StudentDto IStudentService.Find(int Id)
        {
            var student = _context.students.Find(Id);
            return new StudentDto
            {
                ClassId = student.ClassId,
                Gender = student.Gender,
                Name = student.Name,
                PhoneNumber = student.PhoneNumber,
                Email = student.Email,
                Id = student.Id
            };
        }

        List<StudentDto> IStudentService.List()
        {
            var students = _context.students.OrderByDescending(p => p.Id).Select(p => new StudentDto
            {
                Id = p.Id,
                Name = p.Name,
                PhoneNumber = p.PhoneNumber,
                Email = p.Email,
                Gender = p.Gender,
                ClassId = p.ClassId
                
            }).ToList();
            return students;
        }

        List<StudentDto> IStudentService.Search(string Name)
        {
            var students = _context.students.Where(p => p.Name.Contains(Name))
                .OrderByDescending(p => p.Id)
                .Select(p => new StudentDto
            {
                Id = p.Id,
                Name = p.Name,
                PhoneNumber = p.PhoneNumber,
                Email = p.Email,
                Gender = p.Gender
            }).ToList();
            return students;
        }
    }
}

