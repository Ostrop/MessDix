using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace MesDixnich.Pages
{
    public class ChatModel : PageModel
    {
        private readonly ApplicationContext _context;
        public User User1 { get; set; }
        public string Message1 { get; set; }
        [BindProperty]
        public Message SendMess { get; set; }
        public ChatModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet(int PersonID)
        {
            User1 = _context.User.FirstOrDefault(p => p.Id == PersonID);
            Message1 = "Добро пожаловать, " + User1.UserName;
        }
    }
}
