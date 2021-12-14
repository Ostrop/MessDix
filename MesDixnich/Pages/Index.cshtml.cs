using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using RazorPagesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesApp.Pages
{
    public class ExchangeModel : PageModel
    {
        private readonly ApplicationContext _context;
        //public List<User> User { get; set; }
        public string Message { get; set; }
        [BindProperty]
        public User User1 { get; set; }
        //public ExchangeModel(ApplicationContext db)
        //{
        //    _context = db;
        //}
        public void OnGet()
        {
            //User = _context.User.AsNoTracking().ToList();
        }
        public IActionResult OnPost()
        {
            if (User1.Login == null || User1.Login == "")
            {
                Message = "Неправильные данные. Попробуйте еще раз.";
                return Page();
            }
            else
                return RedirectToPage("Chat");
        }
    }
}