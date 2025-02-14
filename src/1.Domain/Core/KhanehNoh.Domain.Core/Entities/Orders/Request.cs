using KhanehNoh.Domain.Core.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Entities.Orders
{
    public class Request
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ExecutionDate { get; set; }
        public DateTime RequestAt { get; set; }
        public OrderStatusEnum Status { get; set; }
        public string? PictureUrl { get; set; }
        #endregion

        #region NavigationProperties
        public int HomeServiceId { get; set; }
        public HomeService HomeService { get; set; }
        public List<Rating> Ratings { get; set; }

        public List<Offer> Offers { get; set; }
        #endregion
    }
}
