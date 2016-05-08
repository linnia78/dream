using Dream.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace Dream.Svc
{
    public class ReminderQueryService
    {
        private readonly ReminderRepository _reminderRepo;
        public ReminderQueryService(ReminderRepository reminderRepo)
        {
            this._reminderRepo = reminderRepo;
        }

        public IEnumerable<ReminderQueryResultDto> GetAllReminders()
        {
            return _reminderRepo
                .GetAllReminders()
                .Include(x => x.User)
                .Select(x => new ReminderQueryResultDto
                {
                    ReminderId = x.ReminderId,
                    FirstName = x.User.FirstName,
                    LastName = x.User.LastName
                });
        }
    }
}
