using ConfigServiceDomain.Model;
using Microsoft.EntityFrameworkCore;

namespace ConfigServiceInfrastructure
{
    public class SettingDbContext : DbContext
    {
        public SettingDbContext(DbContextOptions<SettingDbContext> options) : base(options) { }
        public DbSet<Setting> Settings { get; set; }
    }
}