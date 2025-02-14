using KhanehNoh.Domain.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Entities.Orders
{
    public class Rating
    {
        #region Properties
        public int Id { get; set; }
        [Range(1, 5)]
        public int? Rate { get; set; }

        public string? Comment { get; set; }
        #endregion
        #region NavigationProperties
        public User User { get; set; }
        public int UserId { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
        #endregion
    }
}
