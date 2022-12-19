﻿using ConfigServiceDomain.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServiceDomain.Dto
{
    public class SettingDto
    {
        public Guid CardIssuerId { get; set; }
        public bool AllowTextCopy { get; set; }
        public bool EnableSupplyAlert { get; set; }
        public bool EnableLowCardAlert { get; set; }
        public NotificationType NotificationType { get; set; }
        public bool EnableNotification { get; set; }
        public ThemeColor ThemeColor { get; set; }
        public DateTime LastMigrationTime { get; set; }
    }
}