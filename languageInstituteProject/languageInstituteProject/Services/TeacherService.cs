using languageInstituteProject.Data;
using languageInstituteProject.Dtos;
using languageInstituteProject.Models;
using Microsoft.EntityFrameworkCore;

namespace languageInstituteProject.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly DatabaseContext _context;
        public TeacherService(DatabaseContext context)
        {
            _context = context;
        }

        public int Add(TeacherDto teacher)
        {
            Models.Teacher entity = new Models.Teacher
            {
                Email = teacher.Email,
                Name = teacher.Name,
                PhoneNumber = teacher.PhoneNumber
            };

            _context.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public int Delete(int Id)
        {
            _context.teachers.Remove(new Models.Teacher
            {
                Id = Id
            });
            return _context.SaveChanges();
        }

        public TeacherDto Edit(TeacherDto teacher)
        {
            var entity = _context.teachers.Find(teacher.Id);
            entity.Name = teacher.Name;
            entity.PhoneNumber = teacher.PhoneNumber;
            entity.Email = teacher.Email;
            entity.classes = teacher.classes;
            _context.SaveChanges();
            return teacher;
        }

        public TeacherDto Find(int Id)
        {
            var teacher = _context.teachers.Find(Id);
            return new TeacherDto
            {
                Name = teacher.Name,
                PhoneNumber = teacher.PhoneNumber,
                Email = teacher.Email,
                Id = teacher.Id,
                classes = teacher.classes
            };
        }

        public List<TeacherDto> List()
        {
            var teachers = _context.teachers.OrderByDescending(p => p.Id).Select(p => new TeacherDto
            {
                Id = p.Id,
                Name = p.Name,
                PhoneNumber = p.PhoneNumber,
                Email = p.Email,
                classes = p.classes

            }).ToList();
            return teachers;
        }

        public List<TeacherDto> Search(string Name)
        {
            var teachers = _context.teachers.Where(p => p.Name.Contains(Name))
                          .OrderByDescending(p => p.Id)
                          .Select(p => new TeacherDto
                          {
                              Id = p.Id,
                              Name = p.Name,
                              PhoneNumber = p.PhoneNumber,
                              Email = p.Email,
                          }).ToList();
            return teachers;
        }
    }
}
