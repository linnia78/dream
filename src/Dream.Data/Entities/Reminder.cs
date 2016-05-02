using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dream.Data
{
    public class Reminder
    {
        [Key]
        public int ReminderId { get; set; }
        public int UserId { get; set; }

        //Relations
        public User User { get; set; }
        public List<ReminderContent> ReminderContents { get; set; }
    }
}
