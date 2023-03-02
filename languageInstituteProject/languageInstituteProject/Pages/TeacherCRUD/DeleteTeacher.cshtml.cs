using languageInstituteProject.Dtos;
using languageInstituteProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace languageInstituteProject.Pages.TeacherCRUD
{
    public class DeleteTeacherModel : PageModel
    {
        private readonly ITeacherService _teacherService;

        public DeleteTeacherModel(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [BindProperty]
        public TeacherDto Teachers { get; set; } = new TeacherDto();

        public IActionResult OnGet(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            Teachers = _teacherService.Find(Id.Value);

            return Page();
        }
        public IActionResult OnPost()
        {
            _teacherService.Delete(Teachers.Id);
            return RedirectToPage("GetTeachers");
        }
    }
}
