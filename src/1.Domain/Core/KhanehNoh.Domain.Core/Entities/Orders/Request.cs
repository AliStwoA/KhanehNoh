using KhanehNoh.Domain.Core.Entities.BaseEntities;
using KhanehNoh.Domain.Core.Entities.Categories;
using KhanehNoh.Domain.Core.Entities.Users;
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
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public OrderStatusEnum RequestStatus { get; set; }

        public string? PictureUrl { get; set; }
        public bool IsDeleted { get; set; } = false;
        #endregion

        #region NavigationProperties
        public int HomeServiceId { get; set; }
        public HomeService HomeService { get; set; }
        
        public int CityId { get; set; }
        public City City { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Offer>? Offers { get; set; }
        #endregion
    }
}
