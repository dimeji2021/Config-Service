using ConfigServiceDomain.Dto;
using ConfigServiceDomain.Model;
using Microsoft.AspNetCore.JsonPatch;

namespace ConfigServiceInfrastructure.IRepository
{
    public interface ISettingRepository
    {
        Task<Guid> CreateSettings(SettingDto dtoModel);
        IEnumerable<Setting> GetSettings();
        Task<Guid> UpdateSettings(Guid Id, JsonPatchDocument model);
    }
}