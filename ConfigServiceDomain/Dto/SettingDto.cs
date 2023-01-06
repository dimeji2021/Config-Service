using ConfigServiceDomain.Model;

namespace ConfigServiceDomain.Dto
{
    public class SettingDto
    {
        public string EmailAddress { get; set; }
        public bool AllowTextCopy { get; set; }
        public bool EnableSupplyAlert { get; set; }
        public bool EnableLowCardAlert { get; set; }
        public bool EnableNotification { get; set; }
        public int ReOrderLevel { get; set; }
        public DateTime LastMigrationTime { get; set; }
        public SettingDto()
        {

        }
        public SettingDto(Setting setting)
        {
            EmailAddress = setting.EmailAddress;
            AllowTextCopy = setting.AllowTextCopy;
            EnableSupplyAlert = setting.EnableSupplyAlert;
            EnableLowCardAlert = setting.EnableLowCardAlert;
            EnableNotification = setting.EnableNotification;
            ReOrderLevel = setting.ReOrderLevel;
            LastMigrationTime = setting.LastMigrationTime;
        }
    }
}