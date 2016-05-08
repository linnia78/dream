using Dream.Svc;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dream.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ReminderController : Controller
    {
        private readonly ReminderQueryService _reminderQuerySvc;
        public ReminderController(ReminderQueryService reminderQuerySvc)
        //public ReminderController()
        {
            this._reminderQuerySvc = reminderQuerySvc;
        }

        [HttpGet]
        public IActionResult GetAllReminders()
        {
            return Json(this._reminderQuerySvc.GetAllReminders());
        }
    }
}
