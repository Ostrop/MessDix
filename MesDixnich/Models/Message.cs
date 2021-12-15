using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesApp.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public string UserId { get; set; }
        public DateTime SendTime { get; set; }
    }
}