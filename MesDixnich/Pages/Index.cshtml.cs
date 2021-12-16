using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using RazorPagesApp.Models;
using RazorPagesApp.Pages.People;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace RazorPagesApp.Pages
{
    public class ExchangeModel : PageModel
    {
        private readonly ApplicationContext _context;
        public List<User> User { get; set; }
        public string Message { get; set; }
        [BindProperty]
        public User User1 { get; set; }
        public ExchangeModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
            User = _context.User.AsNoTracking().ToList();
        }
        public IActionResult OnPost()
        {
            if (_context.User.Any(e => e.Login == User1.Login && e.Password == User1.Password))
            {
                User userbuf = _context.User.FirstOrDefault(p => p.Login == User1.Login);
                return Redirect("Chat?PersonID=" + userbuf.Id);
            }
            Message = "Неправильные данные. Попробуйте еще раз.";
            return Page();
        }
    }
}