using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Entities.Categories
{
    public class HomeService
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal BasePrice { get; set; }
        public string? PictureUrl { get; set; }
        #endregion

        #region NavigationProperties
        public SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }
        public List<Request> Requests { get; set; } = new List<Request>();

        #endregion

    }
}
