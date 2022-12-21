namespace ConfigServiceDomain.Dto
{
    public class SettingDto
    {
        public string EmailAddress { get; set; }
        public bool AllowTextCopy { get; set; }
        public bool EnableSupplyAlert { get; set; }
        public bool EnableLowCardAlert { get; set; }
        public bool EnableNotification { get; set; }
        public DateTime LastMigrationTime { get; set; }
    }
}