using ConfigServiceDomain.Dto;
using System.Net.Mail;

namespace ConfigServiceDomain.Model
{
    public class Setting
    {
        public Guid Id { get; set; }
        public string EmailAddress { get; set; }
        public bool AllowTextCopy { get; set; }
        public bool EnableSupplyAlert { get; set; }
        public bool EnableLowCardAlert { get; set; }
        public bool EnableNotification { get; set; }
        public DateTime LastMigrationTime { get; set; }
        public Setting()
        {

        }
        public Setting(SettingDto settingDto)
        {
            Id = Guid.NewGuid();
            EmailAddress = settingDto.EmailAddress;
            AllowTextCopy = settingDto.AllowTextCopy;
            EnableSupplyAlert = settingDto.EnableSupplyAlert;
            EnableLowCardAlert = settingDto.EnableLowCardAlert;
            EnableNotification = settingDto.EnableNotification;
            LastMigrationTime = settingDto.LastMigrationTime;
        }
    }
}