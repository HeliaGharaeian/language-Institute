namespace languageInstituteProject.Models
{
    public class Class
    {
        public int Id { get; set; }
        public int ClassNumber { get; set; }
        public Teacher Teacher { get; set; }
    }
}
