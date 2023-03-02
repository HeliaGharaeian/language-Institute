using languageInstituteProject.Dtos;
using languageInstituteProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace languageInstituteProject.Pages.TeacherCRUD
{
    public class EditTeacherModel : PageModel
    {
        private readonly ITeacherService _teacherService;

        public EditTeacherModel(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [BindProperty]
        public TeacherDto Teachers { get; set; } = new TeacherDto();

        public List<SelectListItem> Options { get; set; }


        public IActionResult OnGet(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            Teachers = _teacherService.Find(Id.Value);

            Options = new List<SelectListItem>
        {
            new SelectListItem { Value = "2", Text = "2" },
            new SelectListItem { Value = "3", Text = "3" }
        };

            return Page();
        }
        public IActionResult OnPost()
        {
            _teacherService.Edit(Teachers);
            return Page();
        }
    }
}
