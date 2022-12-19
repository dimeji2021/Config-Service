using ConfigServiceDomain.Dto;
using ConfigServiceDomain.Model;

namespace ConfigServiceInfrastructure.IRepository
{
    public interface ISettingRepository
    {
        Task<Guid> CreateSettings(SettingDto dtoModel);
        IEnumerable<Setting> GetSettings();
        Task<Guid> UpdateSettings(Guid Id, SettingDto model);
    }
}