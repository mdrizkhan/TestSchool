﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Models.StudentModels
{
    public class StudentLoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
