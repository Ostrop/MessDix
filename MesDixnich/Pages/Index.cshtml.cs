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
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid && _context.User.Find() == User1.Login && User.Password != User1.Password && User.UserName != "")
            {
                _context.User.Add(User);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
        //public IActionResult OnPost()
        //{
        //    User = _context.User.AsNoTracking().ToList();
        //    try
        //    {
        //        foreach (var person in User)
        //        {
        //            if (person.Login == User1.Login || person.Password == User1.Password)
        //                return RedirectToPage("Chat");
        //        }
        //            Message = "Неправильные данные. Попробуйте еще раз.";
        //            return Page();
        //    }
        //    catch
        //    {
        //        Message = "Провал";
        //        return Page();
        //    }

        //    //if (User.Login == null || User.Login == "")
        //    //{
        //    //}
        //    //else
        //    //    return RedirectToPage("Chat");
        //}
    }
}