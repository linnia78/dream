using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dream.Data
{
    public class ReminderContent
    {
        [Key]
        public int ReminderContentId { get; set; }
        public int ReminderId { get; set; }
        public string Message { get; set; }

        //Relations
        public Reminder Reminder { get; set; }
    }
}
