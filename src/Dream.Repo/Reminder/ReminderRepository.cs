using Dream.Core;
using Dream.Data;
using System.Collections.Generic;
using System.Linq;

namespace Dream.Repo
{
    public class ReminderRepository : Repository<DreamContext, Reminder>
    {
        public ReminderRepository(DreamContext context) : base(context) { }

        public IQueryable<Reminder> GetAllReminders()
        {
            return base.Context.Reminders;
        }
    }
}
