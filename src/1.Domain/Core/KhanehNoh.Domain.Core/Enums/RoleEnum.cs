﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Enums
{
    public enum RoleEnum
    {
        [Display(Name = "ادمین")]
        Admin = 1,

        [Display(Name = "کارشناس")]
        Expert = 2,

        [Display(Name = "مشتری")]
        Customer = 3
    }
}
