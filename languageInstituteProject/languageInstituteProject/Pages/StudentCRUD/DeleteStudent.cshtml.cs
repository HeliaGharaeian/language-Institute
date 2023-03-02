using languageInstituteProject.Models;
using languageInstituteProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace languageInstituteProject.Pages.StudentCRUD
{
    public class DeleteStudentModel : PageModel
    {
        private readonly IStudentService _studentService;

        public DeleteStudentModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [BindProperty]
        public StudentDto Students { get; set; } = new StudentDto();

        public IActionResult OnGet(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            Students = _studentService.Find(Id.Value);

            return Page();
        }
        public IActionResult OnPost()
        {
            _studentService.Delete(Students.Id);
            return RedirectToPage("GetStudents");
        }

    }
}
