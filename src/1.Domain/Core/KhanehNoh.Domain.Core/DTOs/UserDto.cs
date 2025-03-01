using KhanehNoh.Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public RoleEnum Role { get; set; }
        public string? Address { get; set; }
        public int CityId { get; set; }
        public string? PictureUrl { get; set; }
       

    }
}
