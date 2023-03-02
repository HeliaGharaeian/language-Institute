using languageInstituteProject.Dtos;
using languageInstituteProject.Models;
using languageInstituteProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace languageInstituteProject.Pages.TeacherCRUD
{
    public class CreateTeacherModel : PageModel
    {
        private readonly ITeacherService _teacherService;

        public CreateTeacherModel(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [BindProperty]
        public TeacherDto Teachers { get; set; } = new TeacherDto();

        public List<Teacher> teachers { get; set; }


        public List<SelectListItem> Options { get; set; }

        public void OnGet()
        {
            Options = new List<SelectListItem>
        {
            new SelectListItem { Value = "2", Text = "2" },
            new SelectListItem { Value = "3", Text = "3" }
        };


        }

        public void OnPost()
        {
            _teacherService.Add(Teachers);
        }
    }
}
