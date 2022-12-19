using ConfigServiceDomain.Dto;
using ConfigServiceDomain.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServiceDomain.Model
{
    public class Setting
    {
        public Guid Id { get; set; }
        public Guid CardIssuerId { get; set; }
        public bool AllowTextCopy { get; set; }
        public bool EnableSupplyAlert { get; set; }
        public bool EnableLowCardAlert { get; set; }
        public Color Color { get; set; }
        public NotificationType NotificationType { get; set; }
        public bool EnableNotification { get; set; }
        public ThemeColor ThemeColor { get; set; }
        public DateTime LastMigrationTime { get; set; }
        private Random rnd = new Random();

        public Setting(SettingDto settingDto)
        {
            Id = Guid.NewGuid();
            CardIssuerId = settingDto.CardIssuerId;
            AllowTextCopy = settingDto.AllowTextCopy;
            EnableSupplyAlert = settingDto.EnableSupplyAlert;
            EnableLowCardAlert = settingDto.EnableLowCardAlert;
            Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)); 
            NotificationType = settingDto.NotificationType;
            EnableNotification = settingDto.EnableNotification;
            ThemeColor = settingDto.ThemeColor;
            LastMigrationTime = settingDto.LastMigrationTime;
        }
    }
}