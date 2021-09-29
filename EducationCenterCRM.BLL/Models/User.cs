﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EducationCenterCRM.BLL.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }
    }
}
