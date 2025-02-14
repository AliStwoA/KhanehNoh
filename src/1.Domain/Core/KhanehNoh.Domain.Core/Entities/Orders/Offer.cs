using KhanehNoh.Domain.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Entities.Orders
{
    public class Offer
    {
        #region Properties
        public int Id { get; set; }
        public decimal OfferPrice { get; set; }
        public DateTime DliveryDate { get; set; }
        public string? Description { get; set; }
        public bool IsAccepted { get; set; }
        #endregion

        #region NavigationProperties
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }




        #endregion
    }
}
