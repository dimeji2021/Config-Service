using ConfigServiceDomain.Dto;
using ConfigServiceInfrastructure.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ConfigService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private ISettingRepository _settingRepository;
        public SettingsController(ISettingRepository settingRepository)
        {
            _settingRepository = settingRepository;
        }
        [HttpPost("CreateSettings")]
        public IActionResult CreateStting([FromBody] SettingDto request)
        {
            return Ok(_settingRepository.CreateSettings(request));
        }
        [HttpGet("GetSettings")]
        public IActionResult GetSettings()
        {
            return Ok(_settingRepository.GetSettings());
        }
        [HttpPatch("UpdateSettings/{Id}")]
        public IActionResult UpdateSettings(Guid Id, SettingDto request)
        {
            return Ok(_settingRepository.UpdateSettings(Id, request));
        }
    }
}
