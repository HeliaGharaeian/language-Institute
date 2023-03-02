using languageInstituteProject.Dtos;
using languageInstituteProject.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace languageInstituteProject.Pages.StudentCRUD
{
    public class GetStudentsModel : PageModel
    {
        public List<StudentDto> Students { get; set; } = new List<StudentDto>();

        private readonly IStudentService _studentService;
        public GetStudentsModel(IStudentService studentService)
        {
            _studentService = studentService;
        }



        public void OnGet()
        {
            Students = _studentService.List();

        }
    }
}
