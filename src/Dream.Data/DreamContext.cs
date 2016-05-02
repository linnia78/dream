using Dream.Core;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dream.Data
{
    public class DreamContext : DbContext
    {
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ReminderContent> ReminderContents { get; set; }

        private readonly AppSettings _settings;
        public DreamContext()
        {
            this._settings = new AppSettings();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(this._settings.Configuration["Data:DefaultConnection:ConnectionString"]);
        }
    }
}
