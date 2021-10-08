﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenterCRM.MVC.Configuration
{
    public class SecurityOptions
    {
        public const string SectionTitle = "Security";
        public string AdminUserEmail { get; set; }
        public string ManagerUserEmail { get; set; }
    }
}
