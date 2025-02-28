using KhanehNoh.Domain.Core.Entities.Categories;
using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Entities.Users
{
    public class Expert
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

        public List<HomeService>? HomeServices { get; set; } = new();
        public List<Rating>? Ratings { get; set; } = new();
        public List<Offer>? Offers { get; set; } = new();

       
    }
}
