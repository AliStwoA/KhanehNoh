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
        public decimal Price { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public string Description { get; set; }
        public OrderStatusEnum OfferStatus { get; set; }
        public bool IsAccepted { get; set; }
        #endregion

        #region NavigationProperties
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public int ExpertId { get; set; }
        public Expert Expert { get; set; }
        




        #endregion
    }
}
