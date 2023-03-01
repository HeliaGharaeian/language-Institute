using languageInstituteProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace languageInstituteProject.Pages.StudentCRUD
{
    public class CreateStudentModel : PageModel
    {
        public List<Student> Students { get; set; }

        public void OnGet()
        {
        }
    }
}
