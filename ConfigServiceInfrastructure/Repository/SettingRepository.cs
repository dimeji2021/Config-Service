using ConfigServiceDomain.Dto;
using ConfigServiceDomain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServiceInfrastructure.Repository
{
    public class SettingRepository
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
        public async Task<Guid> UpdateSettings(Guid Id, Setting model)
        {
            //_context.Attach(model).State = EntityState.Modified;
            _context.Entry(_context.Settings.FirstOrDefault(s => s.Id == model.Id)).CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
            return model.Id;
        }
    }
}
