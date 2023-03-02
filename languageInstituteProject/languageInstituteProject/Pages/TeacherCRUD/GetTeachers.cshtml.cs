using languageInstituteProject.Dtos;
using languageInstituteProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace languageInstituteProject.Pages.TeacherCRUD
{
    public class GetTeachersModel : PageModel
    {
        public List<TeacherDto> Teachers { get; set; } = new List<TeacherDto>();

        private readonly ITeacherService _teacherService;
        public GetTeachersModel(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }



        public void OnGet()
        {
            Teachers = _teacherService.List();

        }
    }
}
