﻿using KhanehNoh.Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.DTOs
{
    public class UserSummaryDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string City { get; set; }
        public RoleEnum Role { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
    }
}
