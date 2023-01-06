using ConfigServiceDomain.Dto;
using ConfigServiceDomain.Model;
using Microsoft.AspNetCore.JsonPatch;

namespace ConfigServiceInfrastructure.IRepository
{
    public interface ISettingRepository
    {
        Task<Guid> CreateSettings(SettingDto dtoModel);
        IEnumerable<Setting> GetSettings();
<<<<<<< HEAD
        //Setting GetSettingById(Guid Id);
=======
>>>>>>> c7717e5abbc201e21f4da42eebed42c9014cf8d0
        Task<Guid> UpdateSettings(Guid Id, JsonPatchDocument model);
    }
}