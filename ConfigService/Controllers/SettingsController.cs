using ConfigServiceDomain.Dto;
using ConfigServiceDomain.Model;
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
        public async Task<IActionResult> CreateStting([FromBody] SettingDto request)
        {
            return Ok(await _settingRepository.CreateSettings(request));
        }
        [HttpGet("GetSettings")]
        public IActionResult GetSettings()
        {
            return Ok(_settingRepository.GetSettings());
        }
        [HttpPatch("UpdateSettings/{Id}")]
<<<<<<< HEAD
        public async Task<IActionResult> UpdateSettings([FromRoute] Guid Id, JsonPatchDocument requestUpdate)
        {
            var res = await _settingRepository.UpdateSettings(Id, requestUpdate);
            return res.Equals(Guid.Empty) ? NotFound("setting not found, check that you enter a correct Id") : Ok(res);
=======
        public async Task<IActionResult> UpdateSettings([FromRoute] Guid Id, [FromBody] JsonPatchDocument requestUpdate)
        {
            var res = await _settingRepository.UpdateSettings(Id, requestUpdate);
            return res.Equals(Guid.Empty) ? NotFound("setting not found, check that you enter a correct Id") : Ok(res);
>>>>>>> c7717e5abbc201e21f4da42eebed42c9014cf8d0
        }
    }
}
