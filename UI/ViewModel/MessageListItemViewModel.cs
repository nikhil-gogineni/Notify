using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class MessageListItemViewModel
    {
        public string PriorityRGB { get; set; }
        public string ProfilePictureRGB { get; set; }
        public string Initials { get; set; }
        public User Sender { get; set ; }
        public string Subject { get; set; }
        public string Date { get; set; } = DateTime.Now.ToString("dd/MM/yy");
        public string Time { get; set; } = DateTime.Now.ToString("HH:mm");
        public string Message { get; set; }
        public bool IsRead { get; set; }
    }

    class User
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string email { get; set; }
    }
}
