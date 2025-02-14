using KhanehNoh.Domain.Core.Entities.BaseEntities;
using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Entities.Users
{
    public class User
    {

        #region Property
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Balance { get; set; }
        public string Mobile { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }
        public string? PictureUrl { get; set; }
        public DateTime RegisterAt { get; set; }
        #endregion
        #region NavigationProperties

        public City City { get; set; }
        public int CityId { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public List<Offer> Offers { get; set; }
        public List<Rating> Ratings { get; set; }




        #endregion

    }
}
