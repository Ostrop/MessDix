using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _context;
        public List<User> User { get; set; }
        public IndexModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
            User = _context.User.AsNoTracking().ToList();
        }
    }
}