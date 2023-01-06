using ConfigServiceDomain.Core.Utilities;
using ConfigServiceDomain.Dto;
using ConfigServiceDomain.Eto;
using ConfigServiceDomain.Model;
using ConfigServiceInfrastructure.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServiceInfrastructure.Repository
{
    public class SettingRepository : ISettingRepository
    {
        private SettingDbContext _context;
        public SettingRepository(SettingDbContext setting)
        {
            _context = setting;
        }
        public async Task<Guid> CreateSettings(SettingDto dtoModel)
        {
            var model = new Setting(dtoModel);
            await _context.Settings.AddAsync(model);
            await _context.SaveChangesAsync();
            return model.Id;
        }
        public IEnumerable<Setting> GetSettings()
        {
            return _context.Settings.ToList();
        }
        public async Task<Guid> UpdateSettings(Guid Id, JsonPatchDocument model)
        {
            var setting = await _context.Settings.FindAsync(Id);
            if (setting is not null)
            {
                model.ApplyTo(setting);
                await _context.SaveChangesAsync();
                return Id;
            }
            return Guid.Empty;

        }

        // Trying to authomaticaly send email for reorder level
        void Notify()
        {
            Timer timer = new Timer(e => SendEmail(), null, TimeSpan.Zero, TimeSpan.FromMinutes(1));
        }

        Suscriber sub = new Suscriber();// This will be injected
        void SendEmail()
        {
            var x = sub.Suscribe<StockSummaryEto>();
            Console.WriteLine(x.CopiesLeft);
            var address = CheckAddressDueForReorder(x.CopiesLeft);
            if (address is not null)
            {
                Task func = new Task(() =>
                   {
                       foreach (var email in address)
                       {
                           //send email
                           //The notification service should be called from here
                       };
                   });
                func.Start();
            }
        }
        IEnumerable<string> CheckAddressDueForReorder(int level)
        {
            return _context.Settings.Where(s => s.ReOrderLevel <= level).Select(e => e.EmailAddress);
        }
    }
}
