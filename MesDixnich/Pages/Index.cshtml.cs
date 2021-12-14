using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmptyRazorPagesApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public bool IsCorrect { get; set; } = true;
        public void OnGet(string name, int? age)
        {
            if (age == null || age < 1 || age > 110 || string.IsNullOrEmpty(name))
            {
                IsCorrect = false;
                return;
            }
            Age = age;
            Name = name;
        }
    }
}