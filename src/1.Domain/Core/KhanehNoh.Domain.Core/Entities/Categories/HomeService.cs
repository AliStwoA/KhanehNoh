using KhanehNoh.Domain.Core.Entities.Orders;
using KhanehNoh.Domain.Core.Entities.Users;
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
        public double BasePrice { get; set; }
        public string? PictureUrl { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime RegisterAt { get; set; } = DateTime.Now;
        #endregion

        #region NavigationProperties
        public SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }
        public List<Request>? Requests { get; set; } = new();
        public List<Expert>? Experts { get; set; } = new();

        #endregion

    }
}
