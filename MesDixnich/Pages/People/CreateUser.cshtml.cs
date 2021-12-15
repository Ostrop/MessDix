using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages.People
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationContext _context;
        [BindProperty]
        public User User{ get; set; }
        public CreateModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid && User.Login != "" && User.Password != "" && User.UserName != "")
            {
                _context.User.Add(User);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}