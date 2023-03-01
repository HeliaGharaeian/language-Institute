using languageInstituteProject.Data;
using languageInstituteProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace languageInstituteProject.Pages.StudentCRUD
{
    public class GetStudentsModel : PageModel
    {
        public  List<Student> Students { get; set; } = new List<Student>();

        public GetStudentsModel()
        {
        }

        public void OnGet()
        {

        }
    }
}
