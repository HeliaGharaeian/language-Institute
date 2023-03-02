using languageInstituteProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace languageInstituteProject.Pages.StudentCRUD
{
    public class EditStudentModel : PageModel
    {
        private readonly IStudentService _studentService;

        public EditStudentModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [BindProperty]
        public StudentDto Students { get; set; } = new StudentDto();

        public List<SelectListItem> Options { get; set; }


        public IActionResult OnGet(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            Students = _studentService.Find(Id.Value);

            Options = new List<SelectListItem>
        {
            new SelectListItem { Value = "2", Text = "2" },
            new SelectListItem { Value = "3", Text = "3" }
        };

            return Page();
        }
        public IActionResult OnPost()
        {
            _studentService.Edit(Students);
            return Page();
        }
    }
}
