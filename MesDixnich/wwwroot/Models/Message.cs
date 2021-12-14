using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesDixnich.wwwroot.Models
{
    public class Message
    {
        public int MesId { get; set; }
        public string MesText { get; set; }
        public int UserId { get; set; }
    }
}