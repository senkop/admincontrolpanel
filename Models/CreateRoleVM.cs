﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class CreateRoleVM
    {
        [Required(ErrorMessage = "Role Name Required")]
        public string RoleName { get; set; }
    }
}
