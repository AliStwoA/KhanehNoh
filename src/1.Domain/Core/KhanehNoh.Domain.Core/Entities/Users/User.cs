using KhanehNoh.Domain.Core.Entities.BaseEntities;
using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace KhanehNoh.Domain.Core.Entities.Users
{
    public class User : IdentityUser<int>
    {

        #region Property
  
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        public string? LastName { get; set; }
        public double? Balance { get; set; }
        [MaxLength(500)]
        public string? Address { get; set; }
        [MaxLength(500)]
        public string? PictureUrl { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        #endregion
        #region NavigationProperties

        public City City { get; set; }
        public int CityId { get; set; }
        public Expert? Expert { get; set; }
        public Admin? Admin { get; set; }
        public Customer? Customer { get; set; }

        #endregion

    }
}
